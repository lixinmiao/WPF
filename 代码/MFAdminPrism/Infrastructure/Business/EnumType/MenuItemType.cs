/* ==============================================================================
 * 功能描述：MenuItemType  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/23 17:53:36
 * ==============================================================================*/
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infrastructure.Business.EnumType
{
    /// <summary>
    /// MenuItemType
    /// </summary>
    public enum MenuItemType
    {
        [EnumRemark("Player")]
        Player,
        [EnumRemark("Media Library")]
        MediaLibrary
    }
    
   
}