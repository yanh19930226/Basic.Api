using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Api.Abstractions.Enums
{
    /// <summary>
    /// 平台类型
    /// </summary>
    public enum PlatformType
    {
        /// <summary>
        /// Shopify
        /// </summary>
        Shopify = 1,
        /// <summary>
        /// Xshoppy
        /// </summary>
        XShoppy = 2,
    }

    /// <summary>
    /// 店铺是否启用
    /// </summary>
    public enum IsOpen
    {
        /// <summary>
        /// Close
        /// </summary>
        Close = 0,
        /// <summary>
        /// Open
        /// </summary>
        Open = 1,
    }
}
