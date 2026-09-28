# Downloads cover art for every seeded game into wwwroot/images/games.
#  - Games on Steam: the Steam store header image (already wide, with the title on it)
#  - Everything else (Nintendo games, PlayStation exclusives, etc.): the cover art
#    from the game's Wikipedia article
# Run from Visual Studio's Package Manager Console:  .\tools\download-covers.ps1
# Safe to run again: files that already exist are skipped.

$ErrorActionPreference = 'Stop'
$root = Split-Path -Parent $PSScriptRoot
$dest = Join-Path $root 'wwwroot\images\games'
New-Item -ItemType Directory -Force -Path $dest | Out-Null
$headers = @{ 'User-Agent' = 'AGGRO-portfolio-cover-downloader/1.0 (github.com/scottwesenberg)' }

$steam = @(
    @{ File = 'red-dead-redemption-2.jpg'; AppId = 1174180 },
    @{ File = 'starfield.jpg'; AppId = 1716740 },
    @{ File = 'elden-ring.jpg'; AppId = 1245620 },
    @{ File = 'god-of-war.jpg'; AppId = 1593500 },
    @{ File = 'the-witcher-3-wild-hunt.jpg'; AppId = 292030 },
    @{ File = 'the-elder-scrolls-v-skyrim.jpg'; AppId = 489830 },
    @{ File = 'grand-theft-auto-v.jpg'; AppId = 271590 },
    @{ File = 'the-last-of-us-part-ii.jpg'; AppId = 2531310 },
    @{ File = 'baldur-s-gate-3.jpg'; AppId = 1086940 },
    @{ File = 'cyberpunk-2077.jpg'; AppId = 1091500 },
    @{ File = 'halo-infinite.jpg'; AppId = 1240440 },
    @{ File = 'hades.jpg'; AppId = 1145360 },
    @{ File = 'ghost-of-tsushima.jpg'; AppId = 2215430 },
    @{ File = 'marvel-s-spider-man.jpg'; AppId = 1817070 },
    @{ File = 'sekiro-shadows-die-twice.jpg'; AppId = 814380 },
    @{ File = 'hollow-knight.jpg'; AppId = 367520 },
    @{ File = 'doom.jpg'; AppId = 379720 },
    @{ File = 'portal-2.jpg'; AppId = 620 },
    @{ File = 'bioshock.jpg'; AppId = 409710 },
    @{ File = 'half-life-2.jpg'; AppId = 220 },
    @{ File = 'resident-evil-4.jpg'; AppId = 254700 },
    @{ File = 'metal-gear-solid-v-the-phantom-pain.jpg'; AppId = 287700 },
    @{ File = 'the-last-of-us.jpg'; AppId = 1888930 },
    @{ File = 'fallout-4.jpg'; AppId = 377160 },
    @{ File = 'horizon-zero-dawn.jpg'; AppId = 1151640 },
    @{ File = 'death-stranding.jpg'; AppId = 1190460 },
    @{ File = 'batman-arkham-city.jpg'; AppId = 200260 },
    @{ File = 'it-takes-two.jpg'; AppId = 1426210 },
    @{ File = 'apex-legends.jpg'; AppId = 1172470 },
    @{ File = 'diablo-iv.jpg'; AppId = 2344520 },
    @{ File = 'final-fantasy-vii-remake.jpg'; AppId = 1462040 }
)

$wiki = @(
    @{ File = 'the-legend-of-zelda-breath-of-the-wild.jpg'; Title = 'The Legend of Zelda: Breath of the Wild' },
    @{ File = 'the-legend-of-zelda-tears-of-the-kingdom.jpg'; Title = 'The Legend of Zelda: Tears of the Kingdom' },
    @{ File = 'animal-crossing-new-horizons.jpg'; Title = 'Animal Crossing: New Horizons' },
    @{ File = 'super-mario-odyssey.jpg'; Title = 'Super Mario Odyssey' },
    @{ File = 'super-mario-galaxy.jpg'; Title = 'Super Mario Galaxy' },
    @{ File = 'uncharted-2-among-thieves.jpg'; Title = 'Uncharted 2: Among Thieves' },
    @{ File = 'mass-effect-2.jpg'; Title = 'Mass Effect 2' },
    @{ File = 'bloodborne.jpg'; Title = 'Bloodborne' },
    @{ File = 'super-smash-bros-ultimate.jpg'; Title = 'Super Smash Bros. Ultimate' },
    @{ File = 'mario-kart-8-deluxe.jpg'; Title = 'Mario Kart 8' },
    @{ File = 'overwatch.jpg'; Title = 'Overwatch (video game)' }
)

function Save-AsJpeg([string]$url, [string]$path) {
    $tmp = "$path.download"
    Invoke-WebRequest -Uri $url -OutFile $tmp -Headers $headers -UseBasicParsing
    try {
        # Convert PNG/other formats to JPG so every cover matches its .jpg file name
        Add-Type -AssemblyName System.Drawing
        $img = [System.Drawing.Image]::FromFile($tmp)
        $img.Save($path, [System.Drawing.Imaging.ImageFormat]::Jpeg)
        $img.Dispose()
        Remove-Item $tmp
    } catch {
        Move-Item $tmp $path -Force   # browsers still display it correctly
    }
}

$ok = 0; $skipped = 0; $failed = 0

foreach ($c in $steam) {
    $path = Join-Path $dest $c.File
    if (Test-Path $path) { $skipped++; continue }
    try {
        Invoke-WebRequest -Uri "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/$($c.AppId)/header.jpg" -OutFile $path -Headers $headers -UseBasicParsing
        $ok++; Write-Host "Saved $($c.File) (Steam)"
    } catch { $failed++; Write-Warning "Could not download $($c.File): $($_.Exception.Message)" }
}

# Wikipedia limits how fast scripts can make requests, so go slowly and retry if told to wait
function Invoke-Polite([scriptblock]$action) {
    for ($attempt = 1; $attempt -le 4; $attempt++) {
        try { return & $action }
        catch {
            if ($_.Exception.Message -match '429' -and $attempt -lt 4) {
                $wait = 20 * $attempt
                Write-Host "  Wikipedia says slow down. Waiting $wait seconds..."
                Start-Sleep -Seconds $wait
            } else { throw }
        }
    }
}

foreach ($c in $wiki) {
    $path = Join-Path $dest $c.File
    if (Test-Path $path) { $skipped++; continue }
    try {
        $api = "https://en.wikipedia.org/w/api.php?action=query&format=json&redirects=1&prop=pageimages&piprop=thumbnail&pithumbsize=600&pilicense=any&titles=" + [uri]::EscapeDataString($c.Title)
        $resp = Invoke-Polite { Invoke-RestMethod -Uri $api -Headers $headers }
        $page = $resp.query.pages.PSObject.Properties | Select-Object -First 1 -ExpandProperty Value
        $src = $page.thumbnail.source
        if (-not $src) { throw "No cover image found on Wikipedia for '$($c.Title)'" }
        Start-Sleep -Seconds 3
        Invoke-Polite { Save-AsJpeg $src $path }
        $ok++; Write-Host "Saved $($c.File) (Wikipedia)"
    } catch { $failed++; Write-Warning "Could not download $($c.File): $($_.Exception.Message)" }
    Start-Sleep -Seconds 5
}

Write-Host ""
Write-Host "Done. Downloaded: $ok  Already there: $skipped  Failed: $failed"
