using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        /// <summary>
        /// 店铺
        /// </summary>                                                                                                                                                                   
        /// <returns></returns>
        [HttpGet]
        [Route("GetShopPageList")]
        public IActionResult GetShopPageList()
        {
            return Ok();
        }
    }
}
