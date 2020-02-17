using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bootstrap.Core.Swagger
{
    public class SwaggerConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "DreamBuilder Api";
                    document.Info.Description = "A simple Api preview page for DreamBuilder";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "wilkinwendy",
                        Email = "zhaowenzzl@163.com",
                        Url = "https://github.com/WilkinWendy"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    };
                };
            });
        }

        public static void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            app.UseOpenApi();
            app.UseSwaggerUi();
        }

    }
}
