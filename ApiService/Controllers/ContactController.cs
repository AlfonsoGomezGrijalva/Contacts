using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Models;
using ApiService.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IContactService _clientService;

        public ClientController(ILogger<ClientController> logger, IContactService clientService)
        {            
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<ContactModel>>> Get()
        {
            try
            {
                var clients = await _clientService.GetAllContacts();

                if (clients == null || clients.Count == 0)
                    return NotFound();

                return clients;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving contact lists: {ex.ToString()}");
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }            
        }

        [HttpGet("{lastName}")]
        public async Task<ActionResult<List<ContactModel>>> Get(string lastName)
        {
            try
            {
                if (string.IsNullOrEmpty(lastName))
                    return BadRequest();

                var clients = await _clientService.GetContactByLastName(lastName);

                if (clients == null || clients.Count == 0)
                    return NotFound();

                return clients;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving contacts by lastName: {lastName}. \n {ex.ToString()}");
                return this.StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}