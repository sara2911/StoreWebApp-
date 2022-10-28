using StoreWepApp.Model.DB;
using StoreWepApp.Model.DBContext;
using StoreWepApp.repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.repository.repository
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
      public  ProductRepository (StoreDBConext conext) : base(conext)
        {

        }

       
    }
}
