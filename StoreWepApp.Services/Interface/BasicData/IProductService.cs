using StoreWepApp.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Services.Interface.BasicData
{
    public interface IProductService
    {
        public IQueryable<Product> GetAll();
        public IQueryable<Product> GetAllYsolution();
    }
}
