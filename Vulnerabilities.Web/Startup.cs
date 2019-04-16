using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vulnerabilities.Services.Contracts;
using Vulnerabilities.Services.Implementations;
using Vulnerabilities.Data;
using Vulnerabilites.Data.Context;
using Vulnerabilities.DataManagement;
using Vulnerabilities.Data.Context;

namespace Vulnerabilities.Web
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
            services.AddDbContext<VulnerabilityDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<MpcDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MPC_Connection")));

            services.AddDbContext<MPCMissingPatchDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MPC_MissingPatch_Connection")));

            services.AddDbContext<MDCMissingPatchDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MDC_MissingPatch_Connection")));

            services.AddTransient<DataLoad>();
            services.AddTransient<IVulnerabilityService, VulnerabilityService>();
            services.AddTransient<IServerService, ServerService>();
            services.AddTransient<IArchiveService, ArchiveService>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DataLoad dataLoad)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


          dataLoad.DataLoadingFromExcel();
            
               
           
        }

     
    }

    
}
