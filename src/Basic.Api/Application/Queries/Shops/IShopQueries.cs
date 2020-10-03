﻿using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto;
using Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Shops
{
    public interface IShopQueries
    {
        CoreResult<IQueryable<Shop>> GetAll();
        PageResult<IQueryable<Shop>> GetPage(PostPageRequestDTO req);
    }
}
