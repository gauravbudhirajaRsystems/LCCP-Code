using Microsoft.OpenApi.Models;
using System.Reflection;

namespace LCCP.WebAPI.Application
{
    /// <summary>
    /// SwaggerConfiguration class used for adding the swagger configuration settings
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Add the swagger configurations
        /// </summary>
        /// <param name="services">ServiceCollection Object</param>
        /// <returns></returns>
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {

            //Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "LCCP API",
                    Version = "v1"
                }); 
                
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
    }
}
