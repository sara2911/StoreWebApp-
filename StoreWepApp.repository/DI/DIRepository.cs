//using Microsoft.Extensions.DependencyInjection;
//using StoreWepApp.repository.Interface;
//using StoreWepApp.repository.repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using StoreWepApp.repository.Interface;
using StoreWepApp.repository.repository;

namespace StoreWepApp.repository.DI
{
    public class DIRepository
    {
        private static IServiceProvider serviceProvider = null;
        public static IServiceProvider ServiceProvider { get; set; }
        public static void Register(IServiceCollection collection)
        {
            collection.AddScoped<IProductRepository, ProductRepository>();
        }
        public static void DisposeServices()
        {
            if (serviceProvider == null)
            {
                return;
            }
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
