using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ProductDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class ProductController : Controller
    {
        private readonly DynamicConsume<ResultProductDto> _resultProduct;
        private readonly DynamicConsume<UpdateProductDto> _updateProduct;
        private readonly DynamicConsume<CreateProductDto> _createProduct;
        private readonly DynamicConsume<object> _objectProduct;

        public ProductController(DynamicConsume<ResultProductDto> resultProduct, DynamicConsume<UpdateProductDto> updateProduct, DynamicConsume<CreateProductDto> createProduct, DynamicConsume<object> objectProduct)
        {
            _resultProduct = resultProduct;
            _updateProduct = updateProduct;
            _createProduct = createProduct;
            _objectProduct = objectProduct;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultProduct.GetListAsync("Products/GetProduct");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto dto)
        {
            var result = await _createProduct.PostAsync("Products", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var values = await _updateProduct.GetByIdAsync("Products/GetProductById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto dto)
        {
            var result = await _updateProduct.PutAsync("Products/UpdateProduct", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _objectProduct.DeleteAsync("Products/DeleteProduct", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
