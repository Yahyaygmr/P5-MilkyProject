using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewslettersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public NewslettersController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("NewsletterList")]
        public IActionResult NewsletterList()
        {
            var values = _serviceManager.NewsletterService.TGetListAll();
            return Ok(values);
        }
        [HttpPost("CreateNewsletter")]
        public IActionResult CreateNewsletter(Newsletter newsletter)
        {
            _serviceManager.NewsletterService.TInsert(newsletter);
            return Ok("Ekleme İşlemi Başarılı");
        }
    }
}
