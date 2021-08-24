using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPages.Data;

namespace RazorPages
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Environment = env;
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        
        #region snippet_ConfigureServices
        public void ConfigureServices(IServiceCollection services)
        {
            if (Environment.IsDevelopment())
            {
                services.AddDbContext<RazorPagesContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("RazorPagesContext")));
            }
            else
            {
                services.AddDbContext<RazorPagesContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("MovieContext")));
            }
            services.AddRazorPages();
        }
        #endregion

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }
    }
}