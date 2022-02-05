using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.MyIdentity
{
    public class MyIdentityRoleUser : IdentityUserRole<Guid>
    {
        public virtual MyIdentityUser Person { get; set; }

        public virtual MyIdentityRole Role { get; set; }

        

    }
}
