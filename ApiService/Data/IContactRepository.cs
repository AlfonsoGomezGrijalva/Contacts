using ApiService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Data
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetContactsFromFile(string filename);
    }
}
