using Basic.Api.Models.Dto.Shop;
using Core.Data.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Commands.Shops
{
    public class CreateShopCommand: Command
    {
        public CreateShopCommand(CreateShopDto dto)
        {
            createShopDto = dto;
        }

        public CreateShopDto createShopDto { get; set; }
    }
}
