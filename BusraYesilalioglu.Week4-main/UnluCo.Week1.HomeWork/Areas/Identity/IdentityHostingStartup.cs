using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnluCo.Week1.HomeWork.Models;
using UnluCo.Week1.HomeWork.MyIdentity;

[assembly: HostingStartup(typeof(UnluCo.Week1.HomeWork.Areas.Identity.IdentityHostingStartup))]
namespace UnluCo.Week1.HomeWork.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}