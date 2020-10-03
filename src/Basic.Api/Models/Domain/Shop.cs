using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Domain
{
    public class Shop:Entity
    {
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
        public virtual Company Company { get; set; }
    }
}
