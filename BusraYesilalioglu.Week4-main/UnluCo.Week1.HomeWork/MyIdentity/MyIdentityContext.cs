using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace UnluCo.Week1.HomeWork.MyIdentity
{
    public class MyIdentityContext
            : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid, Microsoft.AspNetCore.Identity.IdentityUserClaim<Guid>, MyIdentityRoleUser,
                Microsoft.AspNetCore.Identity.IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public MyIdentityContext(DbContextOptions<MyIdentityContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MyIdentityUser>(user =>
            {
                user.Property(u => u.FirstName).HasMaxLength(256).IsRequired();
                user.Property(u => u.LastName).HasMaxLength(256);
            });

            builder.Entity<MyIdentityRoleUser>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.PersonRoles).HasForeignKey(ur => ur.RoleId).IsRequired();

                userRole.HasOne(ur => ur.Person)
                    .WithMany(u => u.PersonRoles).HasForeignKey(ur => ur.UserId).IsRequired();
            });
        }

    }
}
