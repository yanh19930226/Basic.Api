using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.Dto
{
    public class PostPageRequestDTO
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get; set; }
    }
}
