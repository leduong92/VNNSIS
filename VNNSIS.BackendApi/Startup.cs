using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VNNSIS.BackendApi.Helpers;
using VNNSIS.Core.Interfaces;
using VNNSIS.Infrastructure.Data;
using VNNSIS.Infrastructure.EF;
using VNNSIS.Infrastructure.Services;
using VNNSIS.Utilities.Constants;

namespace VNNSIS.BackendApi
{
     public class Startup
     {
          public Startup(IConfiguration configuration)
          {
               _config = configuration;
          }

          public IConfiguration _config { get; }

          // This method gets called by the runtime. Use this method to add services to the container.
          public void ConfigureServices(IServiceCollection services)
          {
               services.AddControllers();
               services.AddDbContext<PgDbContext>(options => options.UseNpgsql(_config.GetConnectionString(SystemConstants.PgDbConnect)));
               services.AddDbContext<SqlDbContext>(options => options.UseSqlServer(_config.GetConnectionString(SystemConstants.SqlDbConnect)));
               services.AddScoped<IUnitOfWork, UnitOfWork>();
               services.AddScoped<IMenuService, MenuService>();
               services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
               services.AddAutoMapper(typeof(MappingProfile));

          }

          // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
          public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
          {
               if (env.IsDevelopment())
               {
                    app.UseDeveloperExceptionPage();
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
