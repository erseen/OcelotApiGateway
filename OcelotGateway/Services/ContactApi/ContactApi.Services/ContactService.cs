using ContactApi.Infrastructure;
using ContactApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApi.Services
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int ID)
        {
            return new ContactDto()
            {
                Id = ID,
                FirstName = "Ersen",
                LastName = "Yılmaz"
            };
        }
    }
}
