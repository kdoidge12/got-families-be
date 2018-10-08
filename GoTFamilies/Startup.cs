using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoTFamilies.Managers;
using GoTFamilies.Models.Data.Families;
using GoTFamilies.Models.Data.Persons;
using GoTFamilies.Models.Domain;
using GoTFamilies.Models.Domain.Families;
using GoTFamilies.Models.Domain.Persons;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace GoTFamilies
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
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info{Title="Game of Thrones", Version = "v1"});
            });
            services.AddCors(
                options=> options.AddPolicy("AllowSpecificOrigin",
                            builder=>builder.WithOrigins("http://localhost:3000")
                                            .AllowAnyMethod()
                                            .AllowAnyOrigin()));

            //Dependency Injection : Each time I have an instance of
            //BaseRepo<TType>, the respective Repo will be created.
            services.AddTransient<BaseRepo<Person>, PersonRepo>();
            services.AddTransient<BaseRepo<Family>, FamilyRepo>();                                            

            //Dependency Injection : Each time I have an instance of
            //BaseManager<TType>, the respective Manager will be created.
            services.AddTransient<BaseManager<Person>, PersonManager>();
            services.AddTransient<BaseManager<Family>, FamilyManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowSpecificOrigin");
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","Game of Thrones Families");
            });
        }
    }
}
