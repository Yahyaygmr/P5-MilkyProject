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
        private readonly DynamicConsume<UpdateMessageDto> _updateMessage;
        private readonly DynamicConsume<CreateMessageDto> _createMessage;
        private readonly DynamicConsume<object> _objectMessage;

        public MessageController(DynamicConsume<ResultMessageDto> resultMessage, DynamicConsume<UpdateMessageDto> updateMessage, DynamicConsume<CreateMessageDto> createMessage, DynamicConsume<object> objectMessage)
        {
            _resultMessage = resultMessage;
            _updateMessage = updateMessage;
            _createMessage = createMessage;
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
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto dto)
        {
            var result = await _createMessage.PostAsync("Messages", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateMessage(int id)
        {
            var values = await _updateMessage.GetByIdAsync("Messages/GetMessageById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDto dto)
        {
            var result = await _updateMessage.PutAsync("Messages/UpdateMessage", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
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
