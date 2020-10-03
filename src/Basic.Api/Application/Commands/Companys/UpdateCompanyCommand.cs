using Basic.Api.Models.Dto.Company;
using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Companys
{
    public class UpdateCompanyCommand : Command
    {
        public UpdateCompanyCommand(UpdateCompanyDto dto)
        {
            updateCompanyDto = dto;
        }

        public UpdateCompanyDto updateCompanyDto { get; set; }
    }
}
