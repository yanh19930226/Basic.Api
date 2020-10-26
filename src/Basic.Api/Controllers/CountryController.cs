using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.Api.Application.Commands.Countries;
using Basic.Api.Application.Queries.Countries;
using Basic.Api.Models.Domain;
using Core.Data.Domain.Bus;
using Core.Result;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{

    /// <summary>
    /// 公司
    /// </summary>
    [Route("Api/Country")]
    [ApiController]
    public class CountryController : Controller
    {

        private readonly IMediatorHandler _bus;
        private readonly ICountryQueries _countryQueries;
        public CountryController(IMediatorHandler bus, ICountryQueries countryQueries)
        {
            _bus = bus;
            _countryQueries = countryQueries;
        }
        /// <summary>
        /// 同步接口获取国家信息
        /// </summary>
        /// <returns></returns>
        [Route("AsyncCountry")]
        [HttpPost]
        public async Task<CoreResult> AsyncCountry()
        {
            CoreResult result = new CoreResult();
            AsyncCountryCommand command = new AsyncCountryCommand();
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("国家同步成功");
            }
            else
            {
                result.Failed("国家同步失败");
            }
            return result;
        }
        /// <summary>
        /// 获取国家信息
        /// </summary>
        /// <returns></returns>
        [Route("GetCountryList")]
        [HttpGet]
        public CoreResult<IQueryable<Country>> GetCountryList()
        {
            return _countryQueries.GetAll();
        }
    }
}
