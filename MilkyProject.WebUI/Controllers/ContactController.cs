using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.MessageDtos;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly DynamicConsume<CreateMessageDto> _dynamicConsumeCreateMessage;

        public ContactController(DynamicConsume<CreateMessageDto> dynamicConsumeCreateMessage)
        {
            _dynamicConsumeCreateMessage = dynamicConsumeCreateMessage;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            createMessageDto.Status = true;
            createMessageDto.SendDate = DateTime.Now;

            var result = await _dynamicConsumeCreateMessage.PostAsync("Messages", createMessageDto);
            if(result>0)
            {
                return RedirectToAction("Index","Default");
            }
            return View(createMessageDto);
        }
    }
}
