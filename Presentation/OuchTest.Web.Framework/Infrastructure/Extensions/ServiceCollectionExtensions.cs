using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OuchTest.Core.Configuration;
using OuchTest.Core.Data;
using OuchTest.Core.Infrastructure;
using System;
using System.Net;

namespace OuchTest.Web.Framework.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add services to the application and configure service provider
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        /// <param name="hostingEnvironment">Hosting environment</param>
        /// <returns>Configured service provider</returns>
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services,
            IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            //most of API providers require TLS 1.2 nowadays
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //add OuchConfig configuration parameters
            var ouchConfig = services.ConfigureStartupConfig<OuchConfig>(configuration.GetSection("Ouch"));

            //add hosting configuration parameters
            services.ConfigureStartupConfig<HostingConfig>(configuration.GetSection("Hosting"));

            //add accessor to HttpContext
            services.AddHttpContextAccessor();

            //create engine and configure service provider
            var engine = EngineContext.Create();
            var serviceProvider = engine.ConfigureServices(services, configuration, ouchConfig);

            //further actions are performed only when the database is installed
            if (!DataSettingsManager.DatabaseIsInstalled)
                return serviceProvider;

            //log application start
            engine.Resolve<ILogger>().Information("Application started");

            return serviceProvider;
        }

        /// <summary>
        /// Create, bind and register as service the specified configuration parameters 
        /// </summary>
        /// <typeparam name="TConfig">Configuration parameters</typeparam>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Set of key/value application configuration properties</param>
        /// <returns>Instance of configuration parameters</returns>
        public static TConfig ConfigureStartupConfig<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig : class, new()
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            //create instance of config
            var config = new TConfig();

            //bind it to the appropriate section of configuration
            configuration.Bind(config);

            //and register it as a service
            services.AddSingleton(config);

            return config;
        }
    }
}