using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
namespace Shop
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public async void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env) {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

            if (env.IsProduction()) {
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello world");
                });
            }
         
        } 
    }
}