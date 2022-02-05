using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.MyIdentity
{
    public class MyIdentityUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenExpirationDate { get; set; }

        public virtual ICollection<MyIdentityRoleUser> PersonRoles { get; set; }
    }

}

