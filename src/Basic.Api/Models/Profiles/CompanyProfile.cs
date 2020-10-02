using AutoMapper;
using Basic.Api.Models.Dto.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Profiles
{
    public class CompanyProfile:Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyAddDto,Models.Domain.Company>();
            CreateMap<CompanyUpdateDto,Domain.Company > ();
        }
    }
}
