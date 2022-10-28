using Microsoft.AspNetCore.Mvc;
using StoreWepApp.Model.DB;
using StoreWepApp.Services.Context;
using StoreWepApp.Services.Interface.BasicData;

namespace StoreWebApp.Controllers
{
    public class ProductController : Controller
    {

        //IBasicDataContext _basicDataContext;
        //IProductService _ProductService;
        //public ProductController(IBasicDataContext basicDataContext, IProductService ProductService)
        //{
        //    this._basicDataContext = basicDataContext;
        //    this._ProductService = ProductService;
        //}

        //[HttpGet]
        //[Route("getAllProductY")]
        //public IActionResult GetAllYsolution()
        //{
        //    return

        //        Ok(_basicDataContext.Product.GetAllYsolution());
        //}


        //[HttpGet]
        //[Route("getAllProduct")]
        //public IActionResult getAllProduct()
        //{
        //    return

        //        Ok(_ProductService.GetAll());
        //}
        //////////////// service


        //private IProductService _ProductService;
        //public ProductController(IProductService ProductService)
        //{
        //    this._ProductService = ProductService;
        //}


        //[HttpGet]
        //[Route("getAllProduct")]
        //public IActionResult getAllProduct()
        //{
        //    return

        //        Ok(_ProductService.GetAll());
        //}
        //////
        /////////////// //////////////////////

        IBasicDataContext _basicDataContext;
        public ProductController(IBasicDataContext basicDataContext)
        {
            this._basicDataContext = basicDataContext;
        }

        [HttpGet]
        [Route("getAllProductY")]
        public IActionResult GetAllYsolution()
        {
            return

                Ok(_basicDataContext.Product.GetAllYsolution());
        }


    }
}
