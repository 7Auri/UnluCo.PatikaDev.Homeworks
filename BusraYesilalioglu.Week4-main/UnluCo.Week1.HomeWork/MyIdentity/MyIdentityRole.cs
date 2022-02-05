
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace UnluCo.Week1.HomeWork.MyIdentity
{
    public class MyIdentityRole : IdentityRole<Guid>
    {
        public MyIdentityRole()
        {
        }

        public MyIdentityRole(string roleName) : base(roleName)
        {
        }

        public virtual ICollection<MyIdentityRoleUser> PersonRoles { get; set; }
    }
}
