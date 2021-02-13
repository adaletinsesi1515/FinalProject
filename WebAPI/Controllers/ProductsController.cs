using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //Attribute  - bir class ile ilgili bilgi verme ve imzalama biçimidir. 
    public class ProductsController : ControllerBase
    {
        //Loosely coupled --> gevşek bağlılık - soyuta bağımlılık var 
        //IoC container --> Değişimin kontrolü

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public List<Product> Get()
        {
            //Dependency Chain --> Bağımlılık zinciri

            var result = _productService.GetAll();
            return result.Data;

        }
    }
}
