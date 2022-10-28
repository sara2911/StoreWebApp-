using StoreWepApp.Model.DB;
using StoreWepApp.repository.Interface;
using StoreWepApp.repository.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.repository
{
    public interface IUnitOfWork : IDisposable
    {
       // IGenericRepository<Product>  ProductRepository { get; }//new
        IProductRepository Product { get; } //ysolution
       

    }
}
