using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Basic.Api.Abstractions.Dtos.Request;
using Basic.Api.Abstractions.Dtos.Request.Company;
using Basic.Api.Application.Commands.Companys;
using Basic.Api.Application.Queries.Companys;
using Basic.Api.Data;
using Basic.Api.Models.Domain;
using Core.Data.Domain.Bus;
using Core.EventBus.Abstractions;
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
        private readonly ICompanyQueries _companyQueries;
        private readonly IMediatorHandler _bus;
        private readonly IEventBus _eventBus;

        public CompanyController(ICompanyQueries companyQueries, IMediatorHandler bus, IEventBus eventBus)
        {
            _companyQueries = companyQueries;
            _bus = bus;
            _eventBus = eventBus;
        }
        /// <summary>
        /// 获取公司
        /// </summary>
        /// <returns></returns>
        [Route("GetCompanyList")]
        [HttpGet]
        public CoreResult<IQueryable<Company>> GetCompanyList()
        {
            return _companyQueries.GetAll();
        }
        /// <summary>
        /// 分页获取公司
        /// </summary>
        /// <returns></returns>
        [Route("GetCompanyPageList")]
        [HttpPost]
        public PageResult<IQueryable<Company>> GetCompanyPageList([FromBody]PostPageRequestDTO dto)
        {
            return _companyQueries.GetPage(dto);
        }
        /// <summary>
        /// 添加公司
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateCompany")]
        public async Task<CoreResult> Create([FromBody] CreateCompanyRequestDto dto)
        {
            CoreResult result = new CoreResult();
            CreateCompanyCommand command = new CreateCompanyCommand(dto.Name, dto.SkuPrefix,dto.AdditionalFee);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("添加成功");
            }
            else
            {
                result.Failed("添加失败");
            }
            return result;
        }
        /// <summary>
        /// 修改公司
        /// </summary>
        /// <returns></returns>
        [Route("UpdateCompany")]
        [HttpPut]
        public async Task<CoreResult> Update([FromBody] UpdateCompanyRequestDto dto)
        {
            CoreResult result = new CoreResult();
            UpdateCompanyCommand command = new UpdateCompanyCommand(dto);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("修改成功");
            }
            else
            {
                result.Failed("修改失败");
            }
            return result;
        }
        /// <summary>
        /// 删除公司
        /// </summary>
        /// <returns></returns>
        [Route("DeleteCompany/{Id}")]
        [HttpDelete]
        public async Task<CoreResult> Delete(long Id)
        {
            CoreResult result = new CoreResult();
            DeleteCompanyCommand command = new DeleteCompanyCommand(Id);
            var res = await _bus.SendCommandAsync(command);
            if (res)
            {
                result.Success("删除成功");
            }
            else
            {
                result.Failed("删除成功");
            }
            return result;
        }
    }
}
