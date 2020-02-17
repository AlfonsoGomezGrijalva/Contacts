using ApiService.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Data
{
    public class ContactRepository : IContactRepository
    {
        public async Task<List<Contact>> GetContactsFromFile(string filename)
        {
            return JsonConvert.DeserializeObject<List<Contact>>(await File.ReadAllTextAsync(filename));
        }
    }
}
