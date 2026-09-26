using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AllGamesGameReviews.Data;
using AllGamesGameReviews.Models;

namespace AllGamesGameReviews
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //   .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddDbContext<GameContext>(options =>
                options.UseSqlServer(connectionString));

            // The demo site can't send email, so accounts don't need email confirmation
            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddControllersWithViews();

            //add authorization services
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("readpolicy",
                    builder => builder.RequireRole("Administrator", "Manager", "User"));
                options.AddPolicy("writepolicy",
                    builder => builder.RequireRole("Administrator", "Manager"));
            });

            builder.Services.Configure<IdentityOptions>(options =>
            {
                //PASSWORD SETTINGS
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 1;
            });


            var app = builder.Build();

            // Create/update the database and make sure the roles (and an optional admin) exist
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                services.GetRequiredService<ApplicationDbContext>().Database.Migrate();
                services.GetRequiredService<GameContext>().Database.Migrate();

                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                foreach (var roleName in new[] { "Administrator", "Manager", "User" })
                {
                    if (!await roleManager.RoleExistsAsync(roleName))
                    {
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

                // Admin login comes from configuration (User Secrets locally, host settings in production),
                // never from source code. Keys: SeedAdmin:Email and SeedAdmin:Password
                var adminEmail = builder.Configuration["SeedAdmin:Email"];
                var adminPassword = builder.Configuration["SeedAdmin:Password"];
                if (!string.IsNullOrWhiteSpace(adminEmail) && !string.IsNullOrWhiteSpace(adminPassword))
                {
                    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                    var admin = await userManager.FindByEmailAsync(adminEmail);
                    if (admin == null)
                    {
                        admin = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
                        await userManager.CreateAsync(admin, adminPassword);
                    }
                    if (!await userManager.IsInRoleAsync(admin, "Administrator"))
                    {
                        await userManager.AddToRoleAsync(admin, "Administrator");
                    }
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            await app.RunAsync();
        }
    }
}