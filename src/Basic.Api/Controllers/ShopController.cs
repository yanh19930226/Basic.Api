using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Basic.Api.Data;
using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto.Shop;
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
        private readonly IMapper _mapper;
        private BasicContext _context;
        public ShopController(IMapper mapper, BasicContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        /// <summary>
        /// 获取店铺
        /// </summary>
        /// <returns></returns>
        [Route("GetShopList")]
        [HttpGet]
        public IActionResult GetShopList()
        {
            var result = _context.Shops.ToList();
            return Ok(result);
        }
        /// <summary>
        /// 分页店铺
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetShopPageList")]
        public IActionResult GetShopPageList()
        {


            return Ok();
        }/// <summary>
         /// 添加店铺
         /// </summary>
         /// <returns></returns>
        [HttpPost]
        [Route("AddShop")]
        public async Task<IActionResult> Add([FromBody]ShopAddDto dto)
        {
            var shop = _mapper.Map<Shop>(dto);
            _context.Shops.Add(shop);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
        /// <summary>
        /// 修改店铺
        /// </summary>
        /// <returns></returns>
        [Route("UpdateShop")]
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ShopUpdateDto dto)
        {
            var shop = _context.Shops.Where(p => p.Id == dto.Id).FirstOrDefault();
            dto.Adapt(shop);
            _context.Update(shop);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
        /// <summary>
        /// 删除店铺
        /// </summary>
        /// <returns></returns>
        [Route("DeleteShop/{Id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            var shop = _context.Shops.Where(p => p.Id == Id).FirstOrDefault();
            _context.Shops.Remove(shop);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
    }
}
