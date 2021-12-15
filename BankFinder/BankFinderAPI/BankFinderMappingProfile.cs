using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BankFinderAPI.Entities;
using BankFinderAPI.Models;

namespace BankFinderAPI
{
    public class BankFinderMappingProfile : Profile
    {
        public BankFinderMappingProfile()
        {
            CreateMap<Institution, InstitutionDto>();
            CreateMap<BinNumber, BinNumberDto>();
            CreateMap<Unit, UnitDto>();
            CreateMap<PhoneNumber, PhoneNumberDto>();
            CreateMap<FaxNumber, FaxNumberDto>();
            CreateMap<SortCode, SortCodeDto>();
            CreateMap<BicCode, BicCodeDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<OpeningHours, OpeningHoursDto>();
        }
    }
}
