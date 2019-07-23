using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MovieAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                var token = context.Request.Headers["token"].ToString();
                if (!validateToken(token))
                {
                    await context.Response.WriteAsync("Invalid token");
                }
                else
                {
                    await next();
                }
            });

            app.UseMvc();
        }
        bool validateToken(string token)
        {
            //validation will add here 
            if (token.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
