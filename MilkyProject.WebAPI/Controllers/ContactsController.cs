using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstracts;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ContactsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact()
        {
            var values = _serviceManager.ContactService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetContactById/{id}")]
        public IActionResult GetContactById(int id)
        {
            var values = _serviceManager.ContactService.TGetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _serviceManager.ContactService.TInsert(contact);
            return Ok("İletişim Alanı Eklendi");
        }
        [HttpPut("UpdateContact")]
        public IActionResult UpdateContact(Contact contact)
        {
            _serviceManager.ContactService.TUpdate(contact);
            return Ok("İletişim Alanı Güncellendi");
        }
        [HttpDelete("DeleteContact/{id}")]
        public IActionResult DeleteContact(int id)
        {
            _serviceManager.ContactService.TDelete(id);
            return Ok("İletişim Alanı Silindi");
        }
    }
}
