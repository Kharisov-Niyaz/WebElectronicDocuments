using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VueCliMiddleware;
using WebElectronicDocuments.Database;
using Microsoft.EntityFrameworkCore;
using WebElectronicDocuments.Classes;
using WebElectronicDocuments.Database._2C;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Classes.Repository;

namespace WebElectronicDocuments
{
    public class Startup
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                    .AllowAnyMethod()
                                                                     .AllowAnyHeader()));
            services.AddControllers(); // используем контроллеры без представлений

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "clientapp";
            });

            services.AddDbContext<_2cContext>(optionsBuilder =>
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS02;Database=2c;Trusted_Connection=True;"));
            
            services.AddDbContext<WedContext>(optionsBuilder =>
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS02;Database=WebElectronicDocument;Trusted_Connection=True;"));

            /**/
            services.AddTransient<IJournal, RJournal>();
            services.AddTransient<IDocFile, RDocFile>();
            services.AddTransient<IUser, RUser>();
            services.AddTransient<IDoc, RDoc>();
            services.AddTransient<IDocJournal, RDocJournal>();
            services.AddTransient<IStage, RStage>();
            /**/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string webRoot = env.WebRootPath;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSpaStaticFiles();
            app.UseAuthorization();
            app.UseCors("AllowAll");
            //app.UseStaticFiles(); // For the wwwroot folder

            app.UseEndpoints(endpoints =>
            {
                // ѕозвол€ет сопоставл€ть запросы с контроллерами. ¬ итоге конкректные маршруты задаютс€ локально с помощью атрибутов контроллера
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                if (env.IsDevelopment())
                    spa.Options.SourcePath = "clientapp/public/dist";
                else
                    spa.Options.SourcePath = "dist";

                if (env.IsDevelopment())
                {
                    spa.UseVueCli(npmScript: "serve", port: 8080);
                }

            });
        }
    }
}
