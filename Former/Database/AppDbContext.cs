using Former.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Former.Database;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    // Takes roles in strings and sets up a list filled with IdentityRole entities
    private List<IdentityRole> GetIdentityRoles(List<string> roleStrings)
    {
        throw new NotImplementedException();
    }
    
    // This is for returning a default IdentityRole list for testing purposes
    private static List<IdentityRole> GetDefaultRoles()
    {
        return
        [
            new IdentityRole
            {
                Id = "FormCreator",
                Name = "FormCreator",
                NormalizedName = "FORMCREATOR"
            },

            new IdentityRole
            {
                Id = "user",
                Name = "User",
                NormalizedName = "USER"
            }
        ];
    }
}