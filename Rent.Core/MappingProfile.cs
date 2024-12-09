using AutoMapper;
using Rent.Core.DTOs;
using Rent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Clinic,ClinicDto>().ReverseMap();
            CreateMap<Tenant,TenantDto>().ReverseMap();
            CreateMap<Turn,TurnDto>().ReverseMap();
        }
    }
}
