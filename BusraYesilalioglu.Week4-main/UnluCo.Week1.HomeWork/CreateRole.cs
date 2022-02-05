using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.MyIdentity;

namespace UnluCo.Week1.HomeWork
{
    public class CreateRole
    {
        private void CreateRoles(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<MyIdentityRole>>();

            var roleNames = new string[] { RoleNames.Admin, RoleNames.Member, RoleNames.Guest };

            foreach (var roleName in roleNames)
            {

                var roleExists = roleManager.RoleExistsAsync(roleName);
                if (!roleExists.Result)
                {
                    roleManager.CreateAsync(new MyIdentityRole(roleName));
                }
            }
        }
    }
}
