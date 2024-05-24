using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.WhyUsDetailDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class WhyUsDetailController : Controller
    {
        private readonly DynamicConsume<ResultWhyUsDetailDto> _resultWhyUsDetail;
        private readonly DynamicConsume<UpdateWhyUsDetailDto> _updateWhyUsDetail;
        private readonly DynamicConsume<CreateWhyUsDetailDto> _createWhyUsDetail;
        private readonly DynamicConsume<object> _objectWhyUsDetail;

        public WhyUsDetailController(DynamicConsume<ResultWhyUsDetailDto> resultWhyUsDetail, DynamicConsume<UpdateWhyUsDetailDto> updateWhyUsDetail, DynamicConsume<CreateWhyUsDetailDto> createWhyUsDetail, DynamicConsume<object> objectWhyUsDetail)
        {
            _resultWhyUsDetail = resultWhyUsDetail;
            _updateWhyUsDetail = updateWhyUsDetail;
            _createWhyUsDetail = createWhyUsDetail;
            _objectWhyUsDetail = objectWhyUsDetail;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultWhyUsDetail.GetListAsync("WhyUsDetails/GetWhyUsDetail");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateWhyUsDetail()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhyUsDetail(CreateWhyUsDetailDto dto)
        {
            var result = await _createWhyUsDetail.PostAsync("WhyUsDetails", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateWhyUsDetail(int id)
        {
            var values = await _updateWhyUsDetail.GetByIdAsync("WhyUsDetails/GetWhyUsDetailById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWhyUsDetail(UpdateWhyUsDetailDto dto)
        {
            var result = await _updateWhyUsDetail.PutAsync("WhyUsDetails/UpdateWhyUsDetail", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteWhyUsDetail(int id)
        {
            var result = await _objectWhyUsDetail.DeleteAsync("WhyUsDetails/DeleteWhyUsDetail", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
