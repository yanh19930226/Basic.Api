using AutoMapper;
using Basic.Api.Abstractions.Dtos.Request.Shop;
using Basic.Api.Abstractions.Dtos.Response.Shop;
using Basic.Api.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Profiles
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            CreateMap<CreateShopRequestDto, Shop>();
            CreateMap<UpdateShopRequestDto, Shop>();

            CreateMap<Shop, ShopResponseDto>();
        }
    }
}
