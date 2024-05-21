using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Areas.Admin.Models;
using MilkyProject.WebUI.Dtos.Category;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class CategoryController : Controller
    {
        private readonly DynamicConsume<ResultCategoryDto> _dynamicConsumeResultCategory;
        private readonly DynamicConsume<CreateCategoryDto> _dynamicConsumeCreateCategory;
        private readonly DynamicConsume<UpdateCategoryDto> _dynamicConsumeUpdateCategory;

        public CategoryController(DynamicConsume<ResultCategoryDto> dynamicConsumeResultCategory, DynamicConsume<CreateCategoryDto> dynamicConsumeCreateCategory, DynamicConsume<UpdateCategoryDto> dynamicConsumeUpdateCategory)
        {
            _dynamicConsumeResultCategory = dynamicConsumeResultCategory;
            _dynamicConsumeCreateCategory = dynamicConsumeCreateCategory;
            _dynamicConsumeUpdateCategory = dynamicConsumeUpdateCategory;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _dynamicConsumeResultCategory.GetListAsync("Categories");
            return View(values);
        }
        public async Task<IActionResult> Detail(int id = 1)
        {
            var values = await _dynamicConsumeResultCategory.GetByIdAsync("Categories/GetCategoryById", id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto)
        {
            var result = await _dynamicConsumeCreateCategory.PostAsync("Categories", dto);

            return View();
        }
    }
}
