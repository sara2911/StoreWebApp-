using Microsoft.Extensions.DependencyInjection;
using StoreWepApp.Services.Interface.BasicData;
using StoreWepApp.Services.Services.BasicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Services.DI
{
    public static class DIService
    {
        //private static IServiceProvider serviceProvider = null;

        public static IServiceProvider? ServiceProvider { get; set; }

        public static void Register(IServiceCollection collection)
        {
            collection.AddScoped<IProductService, ProductService>();
        }
        public static void DisposeServices()
        {
            if (ServiceProvider == null)
            {
                return;
            }
            if (ServiceProvider is IDisposable)
            {
                ((IDisposable)ServiceProvider).Dispose();
            }
        }
    }
}
