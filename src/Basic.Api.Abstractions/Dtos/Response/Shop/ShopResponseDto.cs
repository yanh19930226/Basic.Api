using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Api.Abstractions.Dtos.Response.Shop
{
    public class ShopResponseDto
    {
        /// <summary>
        /// ShopId
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 所属公司
        /// </summary>
        public long CompanyId { get; set; }
        /// <summary>
        /// 密钥
        /// </summary>
        public String ApiKey { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsOpen { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Types { get; set; }
        /// <summary>
        /// 订单前缀
        /// </summary>
        public String OrderPrefix { get; set; }
        /// <summary>
        /// 货币
        /// </summary>
        public String Currency { get; set; }
        /// <summary>
        /// 域名
        /// </summary>
        public String Domain { get; set; }
        /// <summary>
        /// 后台地址
        /// </summary>
        public String AdminUrl { get; set; }
        /// <summary>
        /// ApiKeyValue
        /// </summary>
        public String ApiKeyValue { get; set; }
        /// <summary>
        /// ApiUrl
        /// </summary>
        public String ApiUrl { get; set; }
        /// <summary>
        /// ApiUrl
        /// </summary>
        public String ShareKey { get; set; }
    }
}
