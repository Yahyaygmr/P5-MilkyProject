using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService ProductService)
        {
            _productService = ProductService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product Product)
        {
            _productService.TInsert(Product);
            return Ok("Kategori başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult CreateProduct(int id)
        {
            _productService.TDelete(id);
            return Ok("Kategori başarıyla Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product Product)
        {
            _productService.TUpdate(Product);
            return Ok("Katgori başarıyla güncellendi");
        }
        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpGet("GetProductWithCategory")]
        public IActionResult GetProductWithCategory()
        {
            var values = _productService.TGetProductsWithCategory();
            return Ok(values);
        }

    }
}
