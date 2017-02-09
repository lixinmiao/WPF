/* ==============================================================================
 * 功能描述：SaveMediaDetailEvent  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/8 12:04:01
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
    /// SaveMediaDetailEvent
    /// </summary>
    public class SaveMediaDetailEvent: CompositePresentationEvent<FileItem>
    {
    }
}