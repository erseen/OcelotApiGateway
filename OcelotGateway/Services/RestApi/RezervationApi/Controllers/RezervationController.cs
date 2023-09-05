using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationApi.Infrastructure;
using RezervationApi.Models;

namespace RezervationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervationController :ControllerBase
    {
        private readonly IRezervationService _rezervationService;

        public RezervationController(IRezervationService rezervationService)
        {
            _rezervationService = rezervationService;
        }
        [HttpGet("{id}")]
        public RezervationDto Get(int id) 
        {
            return _rezervationService.GetResultByBkgNumber(id);
        }
    }
}
