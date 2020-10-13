using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Models.Domain;
using Core.Data.Domain.Interfaces;
using Core.Extensions;
using Core.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.ExchangeRates
{
    public class ExchangeRateQueries : IExchangeRateQueries
    {
        public readonly IRepository<ExchangeRate> _exchangeRateRepository;
        public ExchangeRateQueries(IRepository<ExchangeRate> exchangeRateRepository)
        {
            _exchangeRateRepository = exchangeRateRepository;
        }
        public CoreResult<IQueryable<ExchangeRate>> GetAll()
        {
            var result = new CoreResult<IQueryable<ExchangeRate>>();
            var ExchangeRate = _exchangeRateRepository.GetAll().AsNoTracking();
            if (ExchangeRate == null)
            {
                result.Failed("数据不存在");
                return result;
            }
            result.Success(ExchangeRate);
            return result;
        }

        public PageResult<IQueryable<ExchangeRate>> GetPage(PostPageRequestDTO req)
        {
            var expression = LinqExtensions.True<ExchangeRate>();
            var company = _exchangeRateRepository.GetAll().ToPage(req.PageIndex, req.PageSize, expression, p => p.Id, true);
            return company;
        }
    }
}
