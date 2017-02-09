/* ==============================================================================
 * 功能描述：StirngEnum  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/23 18:01:02
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Infrastructure.Common
{
    /// <summary>
    /// StirngEnum
    /// </summary>
    public static class EnumRemarkExtend
    {
        public static string GetRemark(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo field = type.GetField(value.ToString());
            EnumRemarkAttribute remarkAttribute = (EnumRemarkAttribute)field.GetCustomAttribute(typeof(EnumRemarkAttribute));
            return remarkAttribute.EnumRemark;
        }

        /// <summary>  
        /// 获取备注信息对应的枚举值  
        /// </summary>  
        /// <param name="remark"></param>  
        /// <returns></returns>  
        public static string ByRemark<T>(this string remark)
        {
            Type type = typeof(T);
            FieldInfo[] fds = type.GetFields();
            foreach (var fd in fds)
            {
                object[] attrs = fd.GetCustomAttributes(typeof(EnumRemarkAttribute), false);
                foreach (EnumRemarkAttribute attr in attrs)
                {
                    var name = attr.EnumRemark;
                    if (name == remark)
                        return fd.Name;
                }
            }
            return null;
        }
    }
}