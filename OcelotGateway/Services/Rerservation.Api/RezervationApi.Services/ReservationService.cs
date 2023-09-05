using ReservationApi.Infrastructure;
using RezervationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervationApi.Services
{
    public class ReservationService : IRezervationService
    {
        public RezervationDto GetResultByBkgNumber(int BkgNumber)
        {
            return new RezervationDto()
            {
                Id = (new Random()).Next(100),
                BkgNumber = BkgNumber,
                Amount = (new Random()).Next(100),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37)
            };
        }
    }
}
