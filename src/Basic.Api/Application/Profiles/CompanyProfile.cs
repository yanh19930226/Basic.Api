using AutoMapper;
using Basic.Api.Abstractions.Dtos.Request.Company;
using Basic.Api.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CreateCompanyRequestDto, Company>();
            CreateMap<UpdateCompanyRequestDto, Company>();
        }
    }
}
