/* ==============================================================================
 * 功能描述：ViewMediaDetailEvent  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/6 14:46:37
 * ==============================================================================*/
using Infrastructure.Business;
using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Events
{
    /// <summary>
    /// ViewMediaDetailEvent
    /// </summary>
    public class ViewMediaDetailEvent : CompositePresentationEvent<FileItem>
    {
    }
}