using Former.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Former.Database;

public class AppDbContext : IdentityDbContext<User>
{

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
    {
        _config = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData(new List<IdentityRole>
        {
            new IdentityRole
            {
                Id = "admin",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.Empty.ToString()
            },
            new IdentityRole
            {
                Id = "form_creator",
                Name = "FormCreator",
                NormalizedName = "FORM_CREATOR",
                ConcurrencyStamp = Guid.Empty.ToString()
            },
            new IdentityRole
            {
                Id = "user",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.Empty.ToString(),
            }
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(_config.GetConnectionString("MainDatabase"));
    }
    
    private IConfiguration _config;
}