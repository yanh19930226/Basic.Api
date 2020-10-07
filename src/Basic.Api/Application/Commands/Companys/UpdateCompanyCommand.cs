using Basic.Api.Abstractions.Dtos.Request.Company;
using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Companys
{
    public class UpdateCompanyCommand : Command
    {
        public UpdateCompanyCommand(UpdateCompanyRequestDto dto)
        {
            updateCompanyRequestDto = dto;
        }

        public UpdateCompanyRequestDto updateCompanyRequestDto { get; set; }
    }
}
