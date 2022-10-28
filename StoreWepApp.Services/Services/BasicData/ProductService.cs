using StoreWepApp.Model.DB;
using StoreWepApp.repository;
using StoreWepApp.Services.Interface.BasicData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWepApp.Services.Services.BasicData
{
    public class ProductService : IProductService
    {
        public IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {this._unitOfWork = unitOfWork;  

        }
        public IQueryable<Product> GetAll()
        {
          return _unitOfWork.ProductRepository.GetAll();    
        }
        public IQueryable<Product> GetAllYsolution()
        {
            return _unitOfWork.Product.GetAll();
        }
    }
}
