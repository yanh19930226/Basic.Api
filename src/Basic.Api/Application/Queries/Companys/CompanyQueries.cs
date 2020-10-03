using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto;
using Core.Data.Domain.Interfaces;
using Core.Extensions;
using Core.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Application.Queries.Companys
{
    public class CompanyQueries: ICompanyQueries
    {
        public readonly IRepository<Company> _companyRepository;
        public CompanyQueries(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }
        /// <summary>
        /// 列表数据不分页
        /// </summary>
        /// <returns></returns>
        public CoreResult<IQueryable<Company>> GetAll()
        {
            var result = new CoreResult<IQueryable<Company>>();
            var company = _companyRepository.GetAll().AsNoTracking();
            if (company == null)
            {
                result.Failed("数据不存在");
                return result;
            }
            result.Success(company);
            return result;
        }
        /// <summary>
        /// 列表数据分页
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PageResult<IQueryable<Company>> GetPage(PostPageRequestDTO req)
        {
            var expression = LinqExtensions.True<Company>();
            var company = _companyRepository.GetAll().ToPage(req.PageIndex, req.PageSize, expression, p => p.Id, true);
            return company;
        }
    }
}
