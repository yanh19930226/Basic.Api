using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto;
using Core.Data.Domain.Interfaces;
using Core.Extensions;
using Core.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Shops
{
    public class ShopQueries : IShopQueries
    {
        public readonly IRepository<Shop> _shopRepository;
        public ShopQueries(IRepository<Shop> shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public CoreResult<IQueryable<Shop>> GetAll()
        {
            var result = new CoreResult<IQueryable<Shop>>();
            var shop = _shopRepository.GetAll().AsNoTracking();
            if (shop == null)
            {
                result.Failed("数据不存在");
                return result;
            }
            result.Success(shop);
            return result;
        }

        public PageResult<IQueryable<Shop>> GetPage(PostPageRequestDTO req)
        {
            var expression = LinqExtensions.True<Shop>();
            var shop = _shopRepository.GetAll().ToPage(req.PageIndex, req.PageSize, expression, p => p.Id, true);
            return shop;
        }
    }
}
