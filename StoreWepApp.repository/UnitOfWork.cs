using Microsoft.Extensions.DependencyInjection;
using StoreWepApp.Model.DB;
using StoreWepApp.Model.DBContext;
using StoreWepApp.repository.Interface;
using StoreWepApp.repository.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository _Product;//ysolution
        IServiceProvider serviceProvider;
        StoreDBConext Context;
        public IGenericRepository<Product> ProductRepository { get; private set; }//new

       
        public UnitOfWork(StoreDBConext context, IServiceProvider serviceProvider)
        {
            Context = context;
            this.serviceProvider = serviceProvider;
            ProductRepository = new GenericRepository<Product>(Context);//new
        }

        //ysolution
        public IProductRepository  Product
        { 
            get
            {
                return _Product?? serviceProvider.GetService<IProductRepository>();
            }
        }
       
        public void Dispose()
        {
            Context.Dispose();
        }

        
    }

}
