/* ==============================================================================
 * 功能描述：CustomerBorder  
 * 创 建 者：lixinmiao
 * 创建日期：2017/2/4 14:05:17
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infrastructure.Controls
{
    /// <summary>
    /// CustomerBorder
    /// </summary>
    public class CustomerBorder : Border
    {
        //定义路由事件  
        public static readonly RoutedEvent MouseDoubleClickEvent = EventManager.RegisterRoutedEvent("MouseDoubleClick", RoutingStrategy.Direct, typeof(MouseButtonEventHandler), typeof(CustomerBorder));

        public event MouseButtonEventHandler MouseDoubleClick
        {
            add
            {
                base.AddHandler(MouseDoubleClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(MouseDoubleClickEvent, value);
            }
        }

        //定义路由事件  
        public static readonly RoutedEvent MouseSingleClickEvent = EventManager.RegisterRoutedEvent("MouseSingleClick", RoutingStrategy.Direct, typeof(MouseButtonEventHandler), typeof(CustomerBorder));

        public event MouseButtonEventHandler MouseSingleClick
        {
            add
            {
                base.AddHandler(MouseSingleClickEvent, value);
            }
            remove
            {
                base.RemoveHandler(MouseSingleClickEvent, value);
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            MouseButtonEventArgs args = new MouseButtonEventArgs(e.MouseDevice, e.Timestamp, e.ChangedButton, e.StylusDevice);

           
            if (e.ClickCount == 1)
            {
               
                var timer = new System.Timers.Timer(500);
                timer.AutoReset = false;
                timer.Elapsed += new ElapsedEventHandler((o, ex) => this.Dispatcher.Invoke(new Action(() =>
                {
                    var timer2 = (System.Timers.Timer)this.Tag;
                    timer2.Stop();
                    timer2.Dispose();
                    args.RoutedEvent = MouseSingleClickEvent;
                    args.Source = e.OriginalSource;
                    this.RaiseEvent(args); // 发出单击消息
                })));
                timer.Start();
                this.Tag = timer;
               
            }
            if (e.ClickCount > 1)
            {
                args.RoutedEvent = MouseDoubleClickEvent;
                args.Source = e.OriginalSource;
                var timer = this.Tag as System.Timers.Timer;
                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                    this.RaiseEvent(args); // 发出双击消息
                }
            }
            if (args.Handled)
                e.Handled = true; // 将Handled设置为true，从而使该消息被隐藏



        }
    }
}
