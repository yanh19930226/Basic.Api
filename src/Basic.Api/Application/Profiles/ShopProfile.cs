using AutoMapper;
using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto.Shop;
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
            CreateMap<CreateShopDto, Shop>();
            CreateMap<UpdateShopDto, Shop>();
        }
    }
}
