window.addEventListener('load', () => {
    // Grab the canvas and its 2D drawing context
    const canvas = document.getElementById('goldFlakes');
    if (!canvas) return; // only the home page has the gold flake canvas
    const ctx = canvas.getContext('2d');

    // Resize canvas to always fill the window
    function resizeCanvas() {
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
    }
    resizeCanvas(); // initial size
    window.addEventListener('resize', resizeCanvas); // adjust on window resize

    // Track mouse position for repulsion effect
    const mouse = { x: -1000, y: -1000 }; // start "off-screen"
    window.addEventListener('mousemove', e => {
        mouse.x = e.clientX;
        mouse.y = e.clientY;
    });
    window.addEventListener('mouseleave', () => {
        mouse.x = -1000; // reset when mouse leaves window
        mouse.y = -1000;
    });

    // GoldFlake class: represents a single particle
    class GoldFlake {
        constructor(centerX, centerY, maxOffsetX, maxOffsetY) {
            // horizontal spread
            const xOffset = (Math.random() * 2 - 1) * maxOffsetX;

            // vertical offset creates a V "strip"
            // particles higher near center, lower near edges
            const vSlope = -.3; // adjust slope to make it wider/narrower
            const yMax = maxOffsetY * (1 - Math.abs(xOffset) / maxOffsetX * vSlope);

            const yOffset = (Math.random() * 2 - 1) * yMax; // vertical randomness

            this.homeX = centerX + xOffset;
            this.homeY = centerY + yOffset;

            this.x = this.homeX;
            this.y = this.homeY;

            this.size = Math.random() * 3 + 1.5;
            this.alpha = Math.random() * 0.7 + 0.3;

            // slower, bigger bobbing
            this.bobOffset = Math.random() * Math.PI * 2;
            this.bobSpeed = 0.0008 + Math.random() * 0.0007;
            this.bobAmplitude = 15 + Math.random() * 10;

            // horizontal wisp
            this.wispOffset = Math.random() * Math.PI * 2;
            this.wispSpeed = 0.0005 + Math.random() * 0.0005;
            this.wispAmplitude = 5 + Math.random() * 3;
        }

        update() {
            // Bobbing: gently move up/down using sine wave
            this.y = this.homeY + Math.sin(this.bobOffset) * this.bobAmplitude;
            this.bobOffset += this.bobSpeed; // increment phase

            // Wispiness: gently move left/right
            this.x = this.homeX + Math.sin(this.wispOffset) * this.wispAmplitude;
            this.wispOffset += this.wispSpeed; // increment phase

            // Subtle random floating for natural variation
            this.homeX += (Math.random() - 0.5) * 0.05; // small random drift X
            this.homeY += (Math.random() - 0.5) * 0.05; // small random drift Y

            // Mouse repulsion: particles move away from cursor
            const dx = this.x - mouse.x;
            const dy = this.y - mouse.y;
            const dist = Math.sqrt(dx * dx + dy * dy);
            const repulsionRadius = 50; // distance where repulsion begins
            if (dist < repulsionRadius) {
                const force = (repulsionRadius - dist) / repulsionRadius * 0.3; // strength of repulsion (increase for faster reaction)
                this.homeX += (dx / dist) * force;
                this.homeY += (dy / dist) * force;
            }
        }

        draw() {
            // Draw particle with soft glow using radial gradient
            ctx.save();
            ctx.globalAlpha = this.alpha; // particle opacity
            const gradient = ctx.createRadialGradient(this.x, this.y, 0, this.x, this.y, this.size * 3);
            gradient.addColorStop(0, 'rgba(218, 165, 32, 0.7)'); // inner glow
            gradient.addColorStop(1, 'rgba(184, 134, 11, 0)');   // fade to transparent
            ctx.fillStyle = gradient;
            ctx.beginPath();
            ctx.arc(this.x, this.y, this.size, 0, Math.PI * 2); // draw circle
            ctx.fill();
            ctx.restore();
        }
    }

    // Initialize particles
    const centerX = window.innerWidth / 2;      // center X for diamond
    const centerY = window.innerHeight * 0.6;   // center Y (slightly lower than center)
    const maxOffsetX = window.innerWidth / 2;   // width of diamond
    const maxOffsetY = 120;                     // height of diamond
    const numFlakes = 150;                      // number of particles

    const particles = [];
    for (let i = 0; i < numFlakes; i++) {
        particles.push(new GoldFlake(centerX, centerY, maxOffsetX, maxOffsetY));
    }

    // Animation loop
    function animate() {
        ctx.clearRect(0, 0, canvas.width, canvas.height); // clear canvas each frame
        for (const flake of particles) {
            flake.update(); // update positions
            flake.draw();   // draw particle
        }
        requestAnimationFrame(animate); // loop
    }

    animate(); // start animation
});
