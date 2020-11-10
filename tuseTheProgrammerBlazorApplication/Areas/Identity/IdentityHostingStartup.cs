using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using tuseTheProgrammerBlazorApplication.Data;

[assembly: HostingStartup(typeof(tuseTheProgrammerBlazorApplication.Areas.Identity.IdentityHostingStartup))]
namespace tuseTheProgrammerBlazorApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<tuseTheProgrammerBlazorApplicationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("tuseTheProgrammerBlazorApplicationContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<tuseTheProgrammerBlazorApplicationContext>();
            });
        }
    }
}