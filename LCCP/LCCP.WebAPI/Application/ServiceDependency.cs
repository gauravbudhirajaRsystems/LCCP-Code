using LCCP.ApplicationFacade;
using LCCP.Core.ApplicationFacade;
using LCCP.Core.DomainServices;
using LCCP.Core.Repositories;
using LCCP.Repo;
using LCCP.Services;
using System.Data.SqlClient;

namespace LCCP.WebAPI.Application
{
    /// <summary>
    /// ServiceDependency class used for adding the dependencies using the dependency injection
    /// </summary>
    public static class ServiceDependency
    {
        /// <summary>
        /// Add the dependencies using the dependency injection
        /// </summary>
        /// <param name="services">ServiceCollection Object</param>
        /// <param name="connectionString">Database Connectionstring</param>
        /// <returns></returns>
        public static void AddDependencies(this IServiceCollection services, string connectionString)
        {
        
            // Connection Initiatiation
            services.AddSingleton(new SqlConnection(connectionString));
            
            // Base Repository Injection
            services.AddScoped<IRepository, Repository>();
        
            // Testing Dependencies Injection
            services.AddTransient<ITestingRepository, TestingRepository>();
            services.AddTransient<ITestingService, TestingService>();
            services.AddTransient<ITestingAf, TestingAf>();

        }
    }
}
