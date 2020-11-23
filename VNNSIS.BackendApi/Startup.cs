using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VNNSIS.Infrastructure.EF;
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
