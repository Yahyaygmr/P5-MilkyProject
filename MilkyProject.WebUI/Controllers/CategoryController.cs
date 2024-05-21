using Humanizer;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Areas.Admin.Models;
using MilkyProject.WebUI.Dtos.Category;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace MilkyProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly DynamicConsume<CreateCategoryDto> _dynamicConsumeCreateCategory;
        private readonly DynamicConsume<object> _dynamicConsumeDeleteCategory;
        private readonly DynamicConsume<UpdateCategoryDto> _dynamicConsumeUpdateCategory;
        private readonly DynamicConsume<ResultCategoryDto> _dynamicConsumeResultCategory;

        public CategoryController(IHttpClientFactory httpClientFactory, DynamicConsume<CreateCategoryDto> dynamicConsumeCreateCategory, DynamicConsume<object> dynamicConsumeDeleteCategory, DynamicConsume<UpdateCategoryDto> dynamicConsumeUpdateCategory, DynamicConsume<ResultCategoryDto> dynamicConsumeResultCategory)
        {
            _httpClientFactory = httpClientFactory;
            _dynamicConsumeCreateCategory = dynamicConsumeCreateCategory;
            _dynamicConsumeDeleteCategory = dynamicConsumeDeleteCategory;
            _dynamicConsumeUpdateCategory = dynamicConsumeUpdateCategory;
            _dynamicConsumeResultCategory = dynamicConsumeResultCategory;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _dynamicConsumeResultCategory.GetListAsync("Categories");

            if (result != null)
            {
                return View(result);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
        {
            int result = await _dynamicConsumeCreateCategory.PostAsync("Categories", dto);
            if(result>0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
           
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await _dynamicConsumeDeleteCategory.DeleteAsync("Categories", id);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var result = await _dynamicConsumeUpdateCategory.GetByIdAsync("Categories/GetCategoryById", id);
            if (result != null)
            {
                return View(result);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto dto)
        {
            var result = await _dynamicConsumeUpdateCategory.PutAsync("Categories", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}
