using Former.Database;
using Former.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Former;
public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        ConfigureAuth(builder.Services);
        ConfigureDatabase(builder.Services, builder.
            Configuration.
            GetConnectionString("DefaultConnection"));
        
        ConfigureServices(builder.Services);

        var app = builder.Build();
        
        ConfigureApp(app);
    }
    // Add services to the container.
    private static void ConfigureServices(IServiceCollection services)
    { 
        services.AddControllersWithViews();
    }
    
    // This method is just to inject database provider to EntityFramework
    private static void ConfigureDatabase(IServiceCollection services, string? connectionString)
    {
        ArgumentNullException.ThrowIfNull(connectionString);

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }
    
    private static void ConfigureAuth(IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 5;
        }).AddEntityFrameworkStores<AppDbContext>();

        // services.AddAuthentication(options =>
        // {
        //     options.DefaultAuthenticateScheme =
        //         options.DefaultChallengeScheme =
        //             options.DefaultForbidScheme =
        //                 options.DefaultScheme =
        //                     options.DefaultSignInScheme =
        //                         options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
        // }).AddJwtBearer(options =>
        // {
        //     options.TokenValidationParameters = new TokenValidationParameters
        //     {
        //         ValidateIssuer = true,
        //         ValidIssuer = builder.Configuration["Jwt:Issuer"],
        //         ValidateAudience = true,
        //         ValidAudience = builder.Configuration["Jwt:Audience"],
        //         ValidateIssuerSigningKey = true,
        //         IssuerSigningKey = new SymmetricSecurityKey(
        //             System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
        //         )
        //     };
        // });
    }

    private static void ConfigureApp(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();
        
        app.UseAuthentication();
        app.MapStaticAssets();

        app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();


        app.Run();
    }
}