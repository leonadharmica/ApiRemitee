using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRemitee
{
    public class Startup
    {
            private readonly IConfiguration _configuartion;
            public Startup(IConfiguration configuartion)
            {
                _configuartion = configuartion;
            }
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvc();

                services.AddDbContext<DbContext>(o =>
                {
                    o.UseSqlServer(_configuartion["connectionStrings:DbConnectionString"]);
                });
            }
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
                    endpoints.MapControllers();
                });
            }
        }

    }
