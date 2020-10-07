using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Models.Domain;
using Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Companys
{
    public interface ICompanyQueries
    {
        CoreResult<IQueryable<Company>> GetAll();
        PageResult<IQueryable<Company>> GetPage(PostPageRequestDTO req);
    }
}
