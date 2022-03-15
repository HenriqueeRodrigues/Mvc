using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using SecretaryWebMvc.Models;

namespace SecretaryWebMvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthentication("Cong.Cong")
                .AddCookie("Cong.Cong", config => { 
                    config.Cookie.Name = "Cong.Cong"; 
                    config.LoginPath = "/Login"; 
                    config.AccessDeniedPath = "/Home";
                    config.ExpireTimeSpan = TimeSpan.FromHours(1);
                    });

            services.AddAuthentication("Identity.Login")
                .AddCookie("Identity.Login", config => { 
                    config.Cookie.Name = "Identity.Login"; 
                    config.LoginPath = "/Login"; 
                    config.AccessDeniedPath = "/Home";
                    config.ExpireTimeSpan = TimeSpan.FromHours(1);
                    });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<SecretaryWebMvcContext>(options =>
                    //options.UseMySql(Configuration.GetConnectionString("SecretaryWebMvcContext"), builder =>
                    options.UseMySql(Configuration.GetConnectionString("SecretaryWebMvcContext"), builder =>
                        builder.MigrationsAssembly("SecretaryWebMvc")));

           // services.AddScoped<SeedingService>();//Sempre adicionar os novos serviços
            services.AddScoped<PublisherService>();
            services.AddScoped<CongregationService>();
            services.AddScoped<AssistanceService>();
            services.AddScoped<ActivitiesReportService>();
            services.AddScoped<ReportService>();
            services.AddScoped<UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env /*SeedingService seedingservice*/)
        {
            var enUs = new CultureInfo("en-Us");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(enUs),
                SupportedCultures = new List<CultureInfo> { enUs },
                SupportedUICultures = new List<CultureInfo> { enUs}
            };

            app.UseRequestLocalization(localizationOptions); // configuração que o local é dos EUA

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //seedingservice.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
