using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto;
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
