using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using tuseTheProgrammerBlazorApplication.Profiles;
using tuseTheProgrammerBlazorApplication.Services;

namespace tuseTheProgrammerBlazorApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages()
                    .AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(EmployeeProfile));
            services.AddServerSideBlazor();
            services.AddHttpClient<IEmployeeService, EmployeeService>(configureClient: client =>
             {
                 client.BaseAddress = new Uri("https://localhost:44337/");
             });
            services.AddHttpClient<IDepartmentService, DepartmentService>(configureClient: client =>
            {
                client.BaseAddress = new Uri("https://localhost:44337/");
            });

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
