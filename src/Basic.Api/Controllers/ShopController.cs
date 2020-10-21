using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Abstractions.Dtos.Request.Shop;
using Basic.Api.Application.Commands.Shops;
using Basic.Api.Application.Queries.Shops;
using Basic.Api.Data;
using Basic.Api.Models.Domain;
using Core.Data.Domain.Bus;
using Core.Result;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    /// <summary>
    ///店铺
    /// </summary>
    [Route("Api/Shop")]
    [ApiController]
    public class ShopController : Controller
    {
        private readonly IShopQueries _shopQueries;
        private readonly IMediatorHandler _bus;

        public ShopController(IShopQueries shopQueries, IMediatorHandler bus)
        {
            _shopQueries = shopQueries;
            _bus = bus;
        }
        /// <summary>
        /// 获取店铺
        /// </summary>
        /// <returns></returns>
        [Route("GetShopList")]
        [HttpGet]
        public CoreResult<IQueryable<Shop>> GetShopList()
        {
            return _shopQueries.GetAll();
        }
        /// <summary>
        /// 分页店铺
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetShopPageList")]
        public PageResult<IQueryable<Shop>> GetShopPageList([FromBody]PostPageRequestDTO dto)
        {
            return _shopQueries.GetPage(dto);
        }
        /// <summary>
        /// 添加店铺
        /// </summary>
        /// <remarks>
        /// 说明:Domain网站网站前台地址,AdminUrl店铺后台地址
        /// XShoppy中ApiUrl值和Domain值相同
        /// </remarks>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateShop")]
        public async Task<CoreResult> Create([FromBody] CreateShopRequestDto dto)
        {
            CoreResult result = new CoreResult();
            CreateShopCommand command = new CreateShopCommand(dto);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("添加成功");
            }
            else
            {
                result.Failed("添加失败");
            }
            return result;
        }
        /// <summary>
        /// 修改店铺
        /// </summary>
        /// <returns></returns>
        [Route("UpdateShop")]
        [HttpPut]
        public async Task<CoreResult> Update([FromBody] UpdateShopRequestDto dto)
        {
            CoreResult result = new CoreResult();
            UpdateShopCommand command = new UpdateShopCommand(dto);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("修改成功");
            }
            else
            {
                result.Failed("修改失败");
            }
            return result;
        }
        /// <summary>
        /// 删除店铺
        /// </summary>
        /// <returns></returns>
        [Route("DeleteShop/{Id}")]
        [HttpDelete]
        public async Task<CoreResult> Delete(long Id)
        {
            CoreResult result = new CoreResult();
            DeleteShopCommand command = new DeleteShopCommand(Id);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("删除成功");
            }
            else
            {
                result.Failed("删除成功");
            }
            return result;
        }
    }
}
