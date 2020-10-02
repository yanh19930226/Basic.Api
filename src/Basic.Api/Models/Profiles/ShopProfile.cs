using AutoMapper;
using Basic.Api.Models.Dto.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Profiles
{
    public class ShopProfile: Profile
    {
        public ShopProfile()
        {
            CreateMap<ShopAddDto, Models.Domain.Shop>();
            CreateMap<ShopUpdateDto, Domain.Shop>();
        }
    }
}
