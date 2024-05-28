using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.MessageDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class MessageController : Controller
    {
        private readonly DynamicConsume<ResultMessageDto> _resultMessage;
        private readonly DynamicConsume<object> _objectMessage;

        public MessageController(DynamicConsume<ResultMessageDto> resultMessage, DynamicConsume<object> objectMessage)
        {
            _resultMessage = resultMessage;
            _objectMessage = objectMessage;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultMessage.GetListAsync("Messages/GetMessage");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
       
        public async Task<IActionResult> MessageDetail(int id)
        {
            var values = await _resultMessage.GetByIdAsync("Messages/GetMessageById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var result = await _objectMessage.DeleteAsync("Messages/DeleteMessage", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
