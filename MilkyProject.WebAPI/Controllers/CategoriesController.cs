using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebAPI.Dto;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto categoryDto)
        {
            _categoryService.TInsert(new Category() { Name = categoryDto.Name});
            return Ok("Kategori başarıyla eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Kategori başarıyla Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto categoryDto)
        {
            _categoryService.TUpdate(new Category() { CategoryId= categoryDto .CategoryId, Name = categoryDto .Name});
            return Ok("Katgori başarıyla güncellendi");
        }
        [HttpGet("GetCategoryById/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
    }
}
