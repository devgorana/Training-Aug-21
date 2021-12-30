using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serverside_Project_API.Commercial_Rent_Data;
using Serverside_Project_API.Commercial_Sale_Data;
using Serverside_Project_API.Flatmates_Rent_Data;
using Serverside_Project_API.Model;
using Serverside_Project_API.Pg_Hostel_Rent_Data;
using Serverside_Project_API.Post_Ad_Data;
using Serverside_Project_API.Resident_Rent_Data;
using Serverside_Project_API.Resident_Sale_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API
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

            services.AddControllers();
            services.AddDbContextPool<ModelContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ContextConnectionString")));
            services.AddScoped<IResidentSaleData, SqlResidentSaleData>();
            services.AddScoped<IResidentRentData, SqlResidentRentData>();
            services.AddScoped<ICommercialSaleData, SqlCommercialSaleData>();
            services.AddScoped<ICommercialRentData, SqlCommercialRentData>();
            services.AddScoped<IPostAdData, SqlPostAdData>();
            services.AddScoped<IPgHostelRentData, SqlPgHostelRentData>();
            services.AddScoped<IFlatmatesRentData, SqlFlatmatesData>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Serverside_Project_API", Version = "v1" });
            });
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("CorsPolicy");
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Serverside_Project_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
