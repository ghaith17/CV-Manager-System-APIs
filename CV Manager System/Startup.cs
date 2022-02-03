using Databases.Models;
using Databases.Repositories;
using Databases.Repositories.Experience_Information;
using Databases.Repositories.Personal_Informaion;
using Databases.Repositories.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_Manager_System
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
            services.AddCors();

            // services.AddDbContext<RepositoryContext>(options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("ConnectionString")));

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICVRepository, CVRepository>();
            services.AddTransient<IExperience_InfoRepository, Experience_InfoRepository>();
            services.AddTransient<IPersonal_InfoRepository, Personal_InfoRepository>();
            services.AddTransient<ICVServices, CVServices>();
            services.AddTransient<IPersonal_InfoServices, Personal_InfoServices>();

            services.AddTransient<IExperience_InfoServices, Experience_InfoServices>();
            ////services.AddTransient<ICustomerService, CustomerService>();
            //services.AddControllers();
            // services.AddScoped<IRepository, Repository>();
            //services.AddScoped<ICVServices, CVServices>();
            //services.AddScoped<IPersonal_InfoServices, Personal_InfoServices>();
            //services.AddScoped<IExperience_InfoServices, Experience_InfoServices>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
