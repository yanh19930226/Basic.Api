using Basic.Api.Abstractions.Dtos.Request.Shop;
using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Shops
{
    public class CreateShopCommand: Command
    {
        public CreateShopCommand(CreateShopRequestDto dto)
        {
            createShopRequestDto = dto;
        }

        public CreateShopRequestDto createShopRequestDto { get; set; }
    }
}
