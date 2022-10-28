using Microsoft.Extensions.DependencyInjection;
using StoreWepApp.Services.Context;
using StoreWepApp.Services.Interface.BasicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Services.Contexts
{
    public class BasicDataContext : IBasicDataContext
    {
        IServiceProvider serviceProvider;
        public BasicDataContext(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;


        }
        public IProductService Product => serviceProvider.GetService<IProductService>();
    }
}
