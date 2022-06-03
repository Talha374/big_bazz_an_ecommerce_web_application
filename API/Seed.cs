using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var roles = new List<AppRole>
            {
                new AppRole{Name = "Member"},
                new AppRole{Name = "Seller"},
                new AppRole{Name = "Admin"},
                new AppRole{Name = "Moderator"},
            };
            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }
  

            var admin = new AppUser
            {
                DisplayName= "Talha",
                UserName = "admin",
                PhoneNumber = "01303072895",
                Image="https://lh3.googleusercontent.com/a-/AOh14GjR4Jv5vlgQMjq8QVhac7TyzguklDIiFVhejebRYA=s83-c-mo"
            };

            await userManager.CreateAsync(admin, "poipoi");
            await userManager.AddToRolesAsync(admin, new[] {"Admin", "Moderator"});


            var seller = new AppUser
            {
                DisplayName= "Talha",
                UserName = "Seller",
                PhoneNumber = "01783628206",
        
            };

            await userManager.CreateAsync(seller, "poipoi");
            await userManager.AddToRolesAsync(seller, new[] {"Seller"});

            var moderator = new AppUser
            {
                DisplayName= "Talha",
                UserName = "Moderator",
                PhoneNumber = "01912683376",
        
            };

            await userManager.CreateAsync(moderator, "poipoi");
            await userManager.AddToRolesAsync(moderator, new[] {"Moderator"});

            
        }    
    }
}