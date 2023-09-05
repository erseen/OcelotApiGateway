using ContactApi.Infrastructure;
using ContactApi.Models;
using ContactApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private  IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet("{id}")]
        public ContactDto Contact(int id)
        {
         return   _contactService.GetContactById(id);
        }
    }
}
