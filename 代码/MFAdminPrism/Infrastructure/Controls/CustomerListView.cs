/* ==============================================================================
 * 功能描述：CustomerListView  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/22 17:16:23
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Infrastructure.Controls
{
    /// <summary>
    /// CustomerListView
    /// </summary>
    public class CustomerListView:ListView
    {
        public object SelectedObject
        {
            get { return (object)GetValue(SelectedObjectProperty); }
            set { SetValue(SelectedObjectProperty, value); }
        }

        public static readonly DependencyProperty SelectedObjectProperty =
            DependencyProperty.Register("SelectedObject", typeof(object), typeof(CustomerListView), new UIPropertyMetadata(null));

        //定义路由事件  
        public static readonly RoutedEvent MouseRightClickEvent = EventManager.RegisterRoutedEvent("MouseRightClick", RoutingStrategy.Direct, typeof(MouseButtonEventHandler), typeof(ListView));

        public event MouseButtonEventHandler MouseRightClick
        {
            add
            {
                base.AddHandler(MouseRightClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(MouseRightClickEvent, value);
            }
        }

        public static readonly RoutedEvent ItemMouseRightClickEvent = EventManager.RegisterRoutedEvent("ItemMouseRightClick", RoutingStrategy.Direct, typeof(MouseButtonEventHandler), typeof(ListView));

        public event MouseButtonEventHandler ItemMouseRightClick
        {
            add
            {
                base.AddHandler(ItemMouseRightClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(ItemMouseRightClickEvent, value);
            }
        }

        bool isItemSelected = false;
        protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseRightButtonDown(e);

            MouseButtonEventArgs args = new MouseButtonEventArgs(e.MouseDevice, e.Timestamp, e.ChangedButton, e.StylusDevice);

            object item = GetElementFromPoint((ItemsControl)this, e.GetPosition((ItemsControl)this));
            this.SelectedObject = item;

            isItemSelected = (item != null);
            if(!isItemSelected)
            {
                args.RoutedEvent = MouseRightClickEvent;
                args.Source = e.OriginalSource;
                this.RaiseEvent(args); // 发出单击消息
            }
            else
            {
                args.RoutedEvent = ItemMouseRightClickEvent;
                args.Source = e.OriginalSource;
                this.RaiseEvent(args); // 发出单击消息
            }
            if (args.Handled)
                e.Handled = true; // 将Handled设置为true，从而使该消息被隐藏
        }

        private object GetElementFromPoint(ItemsControl itemsControl, Point point)
        {
            UIElement element = itemsControl.InputHitTest(point) as UIElement;
            while (element != null)
            {
                if (element == itemsControl)
                    return null;
                object item = itemsControl.ItemContainerGenerator.ItemFromContainer(element);
                if (!item.Equals(DependencyProperty.UnsetValue))
                    return item;
                element = (UIElement)VisualTreeHelper.GetParent(element);
            }
            return null;
        }
    }
}