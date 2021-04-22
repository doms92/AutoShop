﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Abstractions;
using Microsoft.Extensions.DependencyInjection;
namespace AutoShop.Models
{
    public class IdentityHelper
    {
        // Role Names
        public const string ShopManager = "Shop Manager";
        public const string Customer = "Customer";

        public static void SetIdentityOptions(IdentityOptions options)
        {
            // Setting sign in option
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;

            // Set password strength
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;

            // Set Lockout Options
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            options.Lockout.MaxFailedAccessAttempts = 5;

        }


        public static async Task CreateRoles(IServiceProvider provider,
           params string[] roles)
        {
            RoleManager<IdentityRole> roleManager =
                provider.GetRequiredService < RoleManager<IdentityRole>>();
                
        
            // Create role if it does not exist
            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        internal static async Task CreateShopManager(IServiceProvider serviceProvider)
        {
            const string email = "admin@autoshop.com";
            const string username = "shopmanager";
            const string password = "AutoShop";

            var userManager = serviceProvider.GetRequiredService <UserManager<IdentityUser>> ();

            // Check if any users are in database
            if(userManager.Users.Count() == 0)
            {
                IdentityUser shopmanager = new IdentityUser()
                {
                    Email = email,
                    UserName = username
                };

                // Create Shop Manager
                await userManager.CreateAsync(shopmanager, password);
                
                await userManager.AddToRoleAsync(shopmanager, ShopManager);
            }
        }
    }
}
