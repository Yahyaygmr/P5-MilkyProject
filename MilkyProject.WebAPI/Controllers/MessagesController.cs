using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public MessagesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetMessage")]
        public IActionResult GetMessage()
        {
            var values = _serviceManager.MessageService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetMessageById/{id}")]
        public IActionResult GetMessageById(int id)
        {
            var values = _serviceManager.MessageService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {
            _serviceManager.MessageService.TInsert(message);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut("UpdateMessage")]
        public IActionResult UpdateMessage(Message message)
        {
            _serviceManager.MessageService.TUpdate(message);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("DeleteMessage/{id}")]
        public IActionResult DeleteMessage(int id)
        {
            _serviceManager.MessageService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
    }
}
