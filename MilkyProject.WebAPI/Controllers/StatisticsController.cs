using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public StatisticsController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetProductCount")]
        public IActionResult GetProductCount()
        {
            var value = _categoryService.TGetCategoryCount();
            return Ok(value);
        }
    }
}
