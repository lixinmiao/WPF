/* ==============================================================================
 * 功能描述：MenuItem  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/23 11:33:47
 * ==============================================================================*/
using Infrastructure.Business.EnumType;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Business.MainMenu
{
    /// <summary>
    /// MenuItem
    /// </summary>
    public class MenuItem: NotificationObject
    {
        private String itemName;

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value; RaisePropertyChanged(() => this.ItemName);
            }
        }

        private String itemImageSrc;

        public string ItemImageSrc
        {
            get
            {
                return itemImageSrc;
            }

            set
            {
                itemImageSrc = value; RaisePropertyChanged(() => this.ItemImageSrc);
            }
        }

        private MenuItemType menuItemType;
        public MenuItemType MenuItemType
        {
            get
            {
                return menuItemType;
            }

            set
            {
                menuItemType = value; RaisePropertyChanged(() => this.ItemImageSrc);
            }
        }

       
    }
}