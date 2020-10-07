using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Api.Abstractions.Dtos.Request
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
