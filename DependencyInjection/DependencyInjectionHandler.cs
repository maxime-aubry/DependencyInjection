using DependencyInjection.Interfaces;
using ExceptionManager;
using ExceptionManager.Abstractions.Interfaces;
using LocalizationManager;
using LocalizationManager.Abstractions.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public sealed class DependencyInjectionHandler
    {
        private static DependencyInjectionHandler dependencyInjectionHandler;
        private IServiceProvider serviceProvider;

        private DependencyInjectionHandler()
        {
            this.serviceProvider = this.ConfigureServices();
        }

        public static IServiceProvider ServiceProvider
        {
            get
            {
                if (dependencyInjectionHandler == null)
                {
                    dependencyInjectionHandler = new DependencyInjectionHandler();
                }
                return dependencyInjectionHandler.serviceProvider;
            }
        }

        private IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IExceptionHandler, ExceptionHandler>();
            services.AddSingleton<ILocalizationHandler, LocalizationHandler>();
            services.AddSingleton<DependencyInjectionServices>();
            return services.BuildServiceProvider();
        }
    }
}
