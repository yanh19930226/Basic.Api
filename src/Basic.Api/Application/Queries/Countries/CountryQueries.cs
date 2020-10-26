using Basic.Api.Models.Domain;
using Core.Data.Domain.Interfaces;
using Core.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Countries
{
    public class CountryQueries : ICountryQueries
    {

        public readonly IRepository<Country> _countryRateRepository;
        public CountryQueries(IRepository<Country> countryRateRepository)
        {
            _countryRateRepository = countryRateRepository;
        }
        public CoreResult<IQueryable<Country>> GetAll()
        {
            var result = new CoreResult<IQueryable<Country>>();
            var ExchangeRate = _countryRateRepository.GetAll().AsNoTracking();
            if (ExchangeRate == null)
            {
                result.Failed("数据不存在");
                return result;
            }
            result.Success(ExchangeRate);
            return result;
        }
    }
}
