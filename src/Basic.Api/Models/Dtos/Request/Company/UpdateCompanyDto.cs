using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Dto.Company
{
    public class UpdateCompanyDto
    {
        public long Id { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        public string Name { get; set; }
        /// <summary>
        /// 公司前缀
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        public string SkuPrefix { get; set; }
        /// <summary>
        /// 附加费
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        public decimal AdditionalFee { get; set; }
    }
}
