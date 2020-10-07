using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Basic.Api.Abstractions.Dtos.Request.Company
{
    public class UpdateCompanyRequestDto
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
