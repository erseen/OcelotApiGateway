﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervationApi.Models
{
    public class RezervationDto
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime BkgDate { get; set; }
        public double Amount { get; set; }

    }
}
