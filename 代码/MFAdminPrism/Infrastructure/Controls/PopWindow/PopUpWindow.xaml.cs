/********************************************************************************
** 创建人： 余翔翔
** 创建时间： 2016/1/19
** 描述： 弹出框
** 修改人:  张龙
** 修改时间:  2016/2/24 
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Infrastructure.Controls
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    //[Export(typeof(PopUpWindow))]
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class PopUpWindow : Window
    {
        public PopUpWindow()
        {
            InitializeComponent();
        }

    


        /// <summary>
        /// 设置页面内容
        /// </summary>
        /// <param name="objectFrm"></param>
        public void SetUserControlShow(UserControl objectFrm)
        {
            this.contentControl.Content = objectFrm;
        }

       

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (this.contentControl.Content != null)
            {
                this.contentControl.Content = null;
            }
            this.Close();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
          
            if (this.contentControl.Content != null)
            {
                this.contentControl.Content = null;
            }
        }

        /// <summary>
        /// 窗体拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



    }
}
