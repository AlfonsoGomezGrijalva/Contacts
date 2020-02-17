using ApiService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Service
{
    public interface IContactService
    {
        Task<List<ContactModel>> GetAllContacts();

        Task<List<ContactModel>> GetContactByLastName(string lastName);
    }
}
