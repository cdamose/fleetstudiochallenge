using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MovieAPI.Service;
using MovieAPI.Service.Interface;

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
                var customerid = context.Request.Headers["customer_id"].ToString();
                ITokenService service = new TokenService();
                if (!service.ValidateToken (customerid,token))
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await HttpResponseWritingExtensions.WriteAsync(context.Response, "UnAuthorized Access Found..!");
                }
                else
                {
                    await next();
                }
            });

            app.UseMvc();
        }
        bool validateToken(string token,string customerid)
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
