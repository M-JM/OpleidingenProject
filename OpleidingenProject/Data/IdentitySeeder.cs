using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OpleidingenProject.Data
{
  
        public static  class IdentitySeeder
        {
      
            public static void SeedUsers(UserManager<CustomUser> userManager)
            {
            

            if (userManager.FindByEmailAsync("admin@test.com").Result == null)
                {

                    CustomUser adminUser = new CustomUser();
                    adminUser.UserName = "admin@test.com";
                    adminUser.Email = "admin@test.com";
                    adminUser.EmailConfirmed = true;
                    adminUser.GeboorteDatum = DateTime.Parse("03/12/1995");
                    adminUser.Voornaam = "admin";
                    adminUser.Achternaam = "Super";
                    var result = userManager.CreateAsync(adminUser, "Admin123!").Result;
                    if (result.Succeeded)
                    {


                    Claim[] claims = new Claim[] {
                    new Claim("IsAdmin", "IsAdmin"),
                  
};
                    //add array of claims to user
                    userManager.AddClaimsAsync(adminUser, claims).Wait();

                }
                }

                if (userManager.FindByEmailAsync("user@test.com").Result == null)
            {

                CustomUser NormaalUser = new CustomUser();
                NormaalUser.UserName = "user@test.com";
                NormaalUser.Email = "user@test.com";
                NormaalUser.EmailConfirmed = true;
                NormaalUser.GeboorteDatum = DateTime.Parse("03/12/1995");
                NormaalUser.Voornaam = "admin";
                NormaalUser.Achternaam = "Super";
                var result = userManager.CreateAsync(NormaalUser, "User123!").Result;
                if (result.Succeeded)
                {

                    Claim[] claims = new Claim[] {
                    new Claim("IsUser", "IsUser"),
                   

                };
                    userManager.AddClaimsAsync(NormaalUser, claims).Wait();
                }
            }
      

    }

}

}

