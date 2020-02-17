using ApiService.Data.Entities;
using ApiService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Data
{
    public class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            this.CreateMap<Contact, ContactModel>()
                .ForMember(c => c.Name, o=> o.MapFrom(m => m.firstName))
                .ReverseMap();

            this.CreateMap<Address, AddressModel>()
                .ForMember(c => c.Street, o => o.MapFrom(m => m.streetAddress))
                .ReverseMap();
        }
    }
}
