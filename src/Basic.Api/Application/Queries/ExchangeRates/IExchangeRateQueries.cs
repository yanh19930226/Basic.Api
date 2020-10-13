using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Models.Domain;
using Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.ExchangeRates
{
    public interface IExchangeRateQueries
    {
        CoreResult<IQueryable<ExchangeRate>> GetAll();
        PageResult<IQueryable<ExchangeRate>> GetPage(PostPageRequestDTO req);
    }
}
