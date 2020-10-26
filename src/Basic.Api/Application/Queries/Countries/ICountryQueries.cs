using Basic.Api.Models.Domain;
using Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Countries
{
    public interface ICountryQueries
    {
        CoreResult<IQueryable<Country>> GetAll();
    }
}
