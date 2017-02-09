/* ==============================================================================
 * 功能描述：StringValue  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/23 18:00:32
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Common
{
    /// <summary>
    /// StringValue
    /// </summary>
    public class EnumRemarkAttribute : Attribute
    {
        public EnumRemarkAttribute(string remark)
        {
            _EnumRemark = remark;
        }

        private string _EnumRemark;

        public string EnumRemark
        {
            get
            {
                return _EnumRemark;
            }
        }

    }
}