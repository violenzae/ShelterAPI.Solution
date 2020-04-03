using ShelterAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShelterAPI
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
      services.AddDbContext<ShelterAPIContext>(opt =>
      opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      // Register the Swagger services
      services.AddSwaggerDocument(config =>
      {
        config.PostProcess = document =>
          {
            document.Info.Version = "v1";
            document.Info.Title = "Shelter API";
            document.Info.Description = "A simple ASP.NET Core web API to look up available animals for adoption in a shelter";
            document.Info.TermsOfService = string.Empty;
            document.Info.Contact = new NSwag.OpenApiContact
          {
            Name = "Rachel Schieferstein",
            Email = string.Empty,
            Url = "https://github.com/violenzae/ShelterAPI.Solution"
          };
          document.Info.License = new NSwag.OpenApiLicense
          {
            Name = "Use under MIT",
            Url = string.Empty
          };
        };
      });
      services.AddApiVersioning(o => {
      o.ReportApiVersions = true;
      o.AssumeDefaultVersionWhenUnspecified = true;
      o.DefaultApiVersion = new ApiVersion(1, 0);
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      // Register the Swagger generator and the Swagger UI middlewares
      app.UseOpenApi();
      app.UseSwaggerUi3();

      // app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
