﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Dto.Company
{
    public class CreateCompanyDto
    {
        /// <summary>
        /// 公司名
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(11, ErrorMessage = "{0}最多{1}个字符")]
        public string Name { get; set; }
        /// <summary>
        /// 公司前缀
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(11, ErrorMessage = "{0}最多{1}个字符")]
        public string SkuPrefix { get; set; }
        /// <summary>
        /// 附加费
        /// </summary>
        [Required(ErrorMessage = "{0}不能为空")]
        [StringLength(11, ErrorMessage = "{0}最多{1}个字符")]
        public decimal AdditionalFee { get; set; }
    }
}
