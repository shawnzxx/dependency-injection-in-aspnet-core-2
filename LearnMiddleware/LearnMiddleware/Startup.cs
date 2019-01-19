using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using LearnMiddleware.interfaces;
using LearnMiddleware.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMiddleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //dependent injection must be done in ConfigureServices
        //ConfigureServices method always executes before Configure method
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Use addScoped when a new object is required per HTTP request: e.g. Database connection
            //Every new request coming will instantiate an new DB connection
            services.AddScoped<IMonitoring, GraphiteMonitoring>();
            services.AddScoped<IMonitoring, MySQLMonitoring>();
            services.AddScoped<IDbConnection, MySqlConnection>();

            //Use AddSingleton when object is shared across the entire web app: e.g. Application Configuration
            services.AddSingleton<IConfigurationRoot, AppConfiguration>();

            //This is one way of we create our own object and add to Singleton, we need to handle IDisposable for the appConfig whennever DB connection closed.
            var appConfig = new AppConfiguration();
            services.AddSingleton<IConfigurationRoot>(appConfig);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //set up your middleware inside Configure method
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            //app.Run(async context => { await context.Response.WriteAsync("Hello"); });
            app.UseMvc();
        }
    }
}
