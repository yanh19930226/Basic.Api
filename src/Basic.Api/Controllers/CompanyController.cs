using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Basic.Api.Data;
using Basic.Api.Models.Domain;
using Basic.Api.Models.Dto;
using Basic.Api.Models.Dto.Company;
using Core.Extensions;
using Core.Result;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    /// <summary>
    /// 公司
    /// </summary>
    [Route("Api/Company")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly IMapper _mapper;
        private BasicContext _context;
        public CompanyController(IMapper mapper, BasicContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        /// <summary>
        /// 获取公司
        /// </summary>
        /// <returns></returns>
        [Route("GetCompanyList")]
        [HttpGet]
        public IActionResult GetCompanyList()
        {
            var result = _context.Companys.ToList();
            return Ok(result);
        }
        /// <summary>
        /// 分页获取公司
        /// </summary>
        /// <returns></returns>
        [Route("GetCompanyPageList")]
        [HttpPost]
        public IActionResult GetCompanyPageList([FromBody]PostPageRequestDTO dto)
        {

            PageResult<IQueryable<Company>> obj = new PageResult<IQueryable<Company>>();

            #region Expression Tree MultiOption Search
            var searchexpression = LinqExtensions.True<Company>();

            #endregion

            #region Expression Tree MultiOption Order
            var orderexpression = LinqExtensions.True<Company>();
            #endregion

            var tempData = _context.Companys.Where(searchexpression);
            int total = tempData.Count();

            tempData = tempData.OrderBy(orderexpression).
                  Skip(dto.PageSize * (dto.PageIndex - 1)).
                  Take(dto.PageSize);

            obj.Result = tempData;
            obj.Total = total;
            return Ok(obj);
        }
        /// <summary>
        /// 添加公司
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCompany")]
        public async Task<IActionResult> Add([FromBody]CompanyAddDto dto)
        {
            var company = _mapper.Map<Company>(dto);
            _context.Companys.Add(company);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
        /// <summary>
        /// 修改公司
        /// </summary>
        /// <returns></returns>
        [Route("UpdateCompany")]
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]CompanyUpdateDto dto)
        {
            var company = _context.Companys.Where(p => p.Id == dto.Id).FirstOrDefault();
            dto.Adapt(company);
            _context.Update(company);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
        /// <summary>
        /// 删除公司
        /// </summary>
        /// <returns></returns>
        [Route("DeleteCompany/{Id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(long Id)
        {
            var company = _context.Companys.Where(p => p.Id == Id).FirstOrDefault();
            _context.Companys.Remove(company);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
    }
}
