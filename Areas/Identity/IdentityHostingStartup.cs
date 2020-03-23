using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StrongBartending.Models;

[assembly: HostingStartup(typeof(StrongBartending.Areas.Identity.IdentityHostingStartup))]
namespace StrongBartending.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StrongBartendingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StrongBartendingContextConnection")));

            });
        }
    }
}