using Microsoft.AspNetCore.Mvc;
using MilkyProject.DtoLayer.ContactDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class ContactController : Controller
    {
        private readonly DynamicConsume<ResultContactDto> _resultContact;
        private readonly DynamicConsume<UpdateContactDto> _updateContact;
        private readonly DynamicConsume<CreateContactDto> _createContact;
        private readonly DynamicConsume<object> _objectContact;

        public ContactController(DynamicConsume<ResultContactDto> resultContact, DynamicConsume<UpdateContactDto> updateContact, DynamicConsume<CreateContactDto> createContact, DynamicConsume<object> objectContact)
        {
            _resultContact = resultContact;
            _updateContact = updateContact;
            _createContact = createContact;
            _objectContact = objectContact;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _resultContact.GetListAsync("Contacts/GetContact");
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto dto)
        {
            var result = await _createContact.PostAsync("Contacts", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var values = await _updateContact.GetByIdAsync("Contacts/GetContactById", id);
            if (values != null)
            {
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto dto)
        {
            var result = await _updateContact.PutAsync("Contacts/UpdateContact", dto);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }
        public async Task<IActionResult> DeleteContact(int id)
        {
            var result = await _objectContact.DeleteAsync("Contacts/DeleteContact", id);
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
