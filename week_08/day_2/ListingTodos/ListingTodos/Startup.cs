using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ListingTodos.Entities;
using Microsoft.EntityFrameworkCore;
using ListingTodos.Repositories;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ListingTodos
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<TodoContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListingTodos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;"));
            services.AddScoped<TodoRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();
        }
    }
}
