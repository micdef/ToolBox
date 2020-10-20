using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace ToolBox.Patterns
{
    /// <summary>
    /// Abstract class used to define the "Service Locator"'s class 
    /// </summary>
    public abstract class ServiceLocatorBase
    {
        /// <summary>
        /// Property : Service container
        /// </summary>
        protected IServiceProvider Container { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ServiceLocatorBase()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            Container = serviceCollection.BuildServiceProvider();
        }

        /// <summary>
        /// Method use to define, register and configure available services
        /// </summary>
        /// <param name="serviceCollection">Collection where to add services</param>
        public abstract void ConfigureServices(IServiceCollection serviceCollection);
    }
}
