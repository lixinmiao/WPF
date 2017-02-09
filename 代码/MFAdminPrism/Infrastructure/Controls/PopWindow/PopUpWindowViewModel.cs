/********************************************************************************
** 创建人： 张龙
** 创建时间： 2016/2/20 11:14:24
** 描述： 
** 修改人:  
** 修改时间:  
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel.Composition;

namespace Infrastructure.Controls
{
    [Export(typeof(IPopUpWindowViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PopUpWindowViewModel : NotificationObject, IPopUpWindowViewModel
    {
        private UserControl objectFrm;

        public UserControl ObjectFrm
        {
            get { return objectFrm; }
            set { objectFrm = value; RaisePropertyChanged(() => this.ObjectFrm); }
        }


        private DelegateCommand<ContentControl> closeClick;
       /// <summary>
       /// 窗口关闭
       /// </summary>
        public ICommand BtnCloseClick
       {
           get
           {
               if (closeClick == null)
               {
                   closeClick = new DelegateCommand<ContentControl>(OnCloseExcute);//OnFreeCalcCanExcute
               }
               return closeClick;
           }
       }
       void OnCloseExcute(ContentControl sender)
       {
           if (sender.Content != null)
           {
               sender.Content = null;
           }
           Window window = ((Window)sender.Tag);
           if (window != null)
               window.Close();
       }

      


    }
}
