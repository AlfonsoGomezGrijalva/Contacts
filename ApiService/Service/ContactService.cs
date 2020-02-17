using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Data;
using ApiService.Models;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace ApiService.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _clientRepo;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public ContactService(IConfiguration configuration, IContactRepository clientRepo, IMapper mapper)
        {
            _clientRepo = clientRepo;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<List<ContactModel>> GetAllContacts()
        {
            var clients = await _clientRepo.GetContactsFromFile(_configuration.GetSection("JsonPath").Value);

            return _mapper.Map<List<ContactModel>>(clients);
        }
        
        public async Task<List<ContactModel>> GetContactByLastName(string lastName)
        {
            var clients = await _clientRepo.GetContactsFromFile(_configuration.GetSection("JsonPath").Value);

            var result = _mapper.Map<List<ContactModel>>(clients);

            return result.Where(_ => _.LastName.ToLower() == lastName.ToLower()).AsParallel().ToList();
        }
    }
}
