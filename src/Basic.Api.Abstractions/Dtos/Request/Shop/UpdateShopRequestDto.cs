using Basic.Api.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Api.Abstractions.Dtos.Request.Shop
{
    public class UpdateShopRequestDto
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
        /// ApiKey
        /// </summary>
        public String ApiKey { get; set; }
        /// <summary>
        /// ApiKeyValue
        /// </summary>
        public String ApiKeyValue { get; set; }
        /// <summary>
        /// ApiUrl
        /// </summary>
        public String ApiUrl { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public IsOpen IsOpen { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PlatformType Types { get; set; }
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
    }
}
