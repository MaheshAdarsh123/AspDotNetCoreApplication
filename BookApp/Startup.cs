using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
#if DEBUG
            //The above condition is called Pre Processor. When you change appn to release mode, below code will not work
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // In this method we can also add the HTTP pipeline

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Added in order to use static foles such as images, jquery, js files
            app.UseStaticFiles();

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from 1st MiddleWare");
            //    await next();
            //    await Context.Response.WriteAsync("Hello from 1st MiddleWare");
            //});

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from 2nd MiddleWare");
            //    await next();
            //    await Context.Response.WriteAsync("Hello from 2nd MiddleWare");
            //});

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("Hello from 2nd MiddleWare");
            //    await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
