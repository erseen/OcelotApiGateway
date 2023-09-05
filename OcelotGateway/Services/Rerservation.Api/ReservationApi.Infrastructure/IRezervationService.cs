using RezervationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApi.Infrastructure
{
    public interface IRezervationService
    {
        public RezervationDto GetResultByBkgNumber(int BkgNumber);
    }
}
