using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Api.Controllers
{
    /// <summary>
    /// 公司
    /// </summary>
    [Route("api/company")]
    [ApiController]
    public class CompanyController : Controller
    {
        /// <summary>
        /// 获取公司
        /// </summary>
        /// <returns></returns>
        [Route("getlist")]
        public IActionResult Index()
        {
            return Ok();
        }
        /// <summary>
        /// 添加公司
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("addcompany")]
        public IActionResult Add()
        {
            return Ok();
        }
        /// <summary>
        /// 修改公司
        /// </summary>
        /// <returns></returns>
        [Route("updatecompany")]
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        /// <summary>
        /// 删除公司
        /// </summary>
        /// <returns></returns>
        [Route("deletecompany")]
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
