using StoreWepApp.Services.Interface.BasicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Services.Context
{
    public interface IBasicDataContext
    {
        IProductService Product { get; }
    }
}
