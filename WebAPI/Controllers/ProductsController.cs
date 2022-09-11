using Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService; //Talep Ediyorum

        public ProductsController(IProductService productService) ///BU Referance ı Constructor dan Enjecte ediyoruz
        {
            _productService = productService;
        }

        [HttpGet]
       public IActionResult Get()
        {
           var products= _productService.GetProducts();
            return Ok(products);
        }
    }
}
