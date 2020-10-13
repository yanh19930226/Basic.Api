using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Application.Commands.ExchangeRates;
using Basic.Api.Application.Queries.ExchangeRates;
using Basic.Api.Models.Domain;
using Core.Data.Domain.Bus;
using Core.Result;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    /// <summary>
    ///汇率
    /// </summary>
    [Route("Api/ExchangeRate")]
    [ApiController]
    public class ExchangeRateController : Controller
    {
        private readonly IMediatorHandler _bus;
        private readonly IExchangeRateQueries _exchangeRateQueries;
        public ExchangeRateController(IMediatorHandler bus, IExchangeRateQueries exchangeRateQueries)
        {
            _bus = bus;
            _exchangeRateQueries = exchangeRateQueries;
        }
        /// <summary>
        /// 获取汇率
        /// </summary>
        /// <returns></returns>
        [Route("GetExchangeRateList")]
        [HttpGet]
        public CoreResult<IQueryable<ExchangeRate>> GetExchangeRateList()
        {
            return _exchangeRateQueries.GetAll();
        }
        /// <summary>
        /// 分页获取汇率
        /// </summary>
        /// <returns></returns>
        [Route("GetExchangeRatePageList")]
        [HttpPost]
        public PageResult<IQueryable<ExchangeRate>> GetExchangeRatePageList([FromBody] PostPageRequestDTO dto)
        {
            return _exchangeRateQueries.GetPage(dto);
        }
        /// <summary>
        /// 汇率同步
        /// </summary>
        /// <returns></returns>
        [Route("AsyncExchangeRate")]
        [HttpPost]
        public async Task<CoreResult> AsyncExchangeRate()
        {
            CoreResult result = new CoreResult();
            AsyncExchangeRateCommand command = new AsyncExchangeRateCommand();
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("汇率同步成功");
            }
            else
            {
                result.Failed("汇率同步失败");
            }
            return result;
        }
    }
}
