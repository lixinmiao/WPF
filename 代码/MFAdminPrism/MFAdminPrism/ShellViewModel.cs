﻿/* ==============================================================================
 * 功能描述：ShellViewModel  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/16 12:34:48
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;
using System.Collections.ObjectModel;
using Infrastructure.Business.MainMenu;
using System.Windows.Input;
using Infrastructure.Common;
using Infrastructure.Business.EnumType;
using Microsoft.Practices.Prism.Regions;
using Infrastructure;
using Player.View;

namespace MFAdminPrism
{
    [Export]
    //在MEF中通过在类或属性中添加Export属性标签表明该对象能够被其他部件引入。
    /// <summary>
    /// ShellViewModel
    /// </summary>
    public class ShellViewModel : NotificationObject
    {
        private IRegionManager regionManager =null;

        [ImportingConstructor]
        public ShellViewModel(IRegionManager _regionManager)
        {
            regionManager = _regionManager;
            InitMenuItems();
        }
        private ObservableCollection<MenuItem> menuItemList = new ObservableCollection<MenuItem>();
        public ObservableCollection<MenuItem> MenuItemList
        {
            get
            {
                
                return menuItemList;
            }
            set
            {

                menuItemList = value; RaisePropertyChanged(() => this.MenuItemList);
            }
        }


        private void InitMenuItems()
        {
           

            MenuItem playerMenuItem = new MenuItem();
            playerMenuItem.Index = 0;
            playerMenuItem.MenuItemType = MenuItemType.Player;
            playerMenuItem.ItemName = MenuItemType.Player.GetRemark();
            playerMenuItem.ItemImageSrc = "pack://application:,,,/Infrastructure;component/Resources/Images/player.png";
            menuItemList.Add(playerMenuItem);

            MenuItem medialibraryMenuItem = new MenuItem();
            medialibraryMenuItem.Index = 1;
            medialibraryMenuItem.MenuItemType = MenuItemType.MediaLibrary;
            medialibraryMenuItem.ItemName =MenuItemType.MediaLibrary.GetRemark();
            medialibraryMenuItem.ItemImageSrc = "pack://application:,,,/Infrastructure;component/Resources/Images/medias.png";
            menuItemList.Add(medialibraryMenuItem);

            MenuItem templateMenuItem = new MenuItem();
            templateMenuItem.Index = 2;
            templateMenuItem.MenuItemType = MenuItemType.Template;
            templateMenuItem.ItemName = MenuItemType.Template.GetRemark();
            templateMenuItem.ItemImageSrc = "pack://application:,,,/Infrastructure;component/Resources/Images/template.png";
            menuItemList.Add(templateMenuItem);

        }

        private DelegateCommand<int?> mouseLeftDownCommand;
        public ICommand MouseLeftDownCommand
        {
            get
            {
                if (mouseLeftDownCommand == null)
                {
                    mouseLeftDownCommand = new DelegateCommand<int?>(mouseLeftDownCommandExcute);
                }
                return mouseLeftDownCommand;
            }
            
        }
        private void mouseLeftDownCommandExcute(int?  index)
        {
            //String menuitemname=EnumRemarkExtend.ByRemark<MenuItemType>(menuItemTypeValue);
            //MenuItemType menuItemType = (MenuItemType)Enum.Parse(typeof(MenuItemType), menuitemname);

            MenuItem menuItem = null;
            foreach (MenuItem item in menuItemList)
            {
                if (item.Index == index.Value)
                {
                    item.IsChecked = "True";
                     menuItem= item;
                }
                else
                {
                    item.IsChecked = "False";
                }
            }
            switch (menuItem.MenuItemType)
            {
                case MenuItemType.Player:
                    {
                        //Uri uri = new Uri("PlayerMain", UriKind.Relative);
                        //regionManager.RequestNavigate(RegionNames.MainRegion, uri);
                        object newView = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance(typeof(PlayerMain));
                        if (!this.regionManager.Regions[RegionNames.MainRegion].Views.Contains(newView))
                        {
                            this.regionManager.AddToRegion(RegionNames.MainRegion, newView);
                        }
                        this.regionManager.Regions[RegionNames.MainRegion].Activate(newView);//激活
                    }
                    break;
                case MenuItemType.MediaLibrary:
                    {
                        Uri uri = new Uri("MediaLibraryMain", UriKind.Relative);  
                        regionManager.RequestNavigate(RegionNames.MainRegion, uri);//导航
                    }
                    break;

                case MenuItemType.Template:
                    {
                        Uri uri = new Uri("TemplateMain", UriKind.Relative);
                        regionManager.RequestNavigate(RegionNames.MainRegion, uri);//导航
                    }
                    break;
            }

        }
    }
}