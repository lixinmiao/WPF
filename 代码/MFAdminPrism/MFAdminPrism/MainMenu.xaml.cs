using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MFAdminPrism
{
    /// <summary>
    /// MainMenu.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            mySolidColorBrush1.Color = Colors.Red;
            StackPanel stackpanel = sender as StackPanel;
            TextBlock textblock= stackpanel.FindName("itemname") as TextBlock;
            //textblock.Foreground = mySolidColorBrush1;
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush mySolidColorBrush1 = new SolidColorBrush();
            mySolidColorBrush1.Color = Colors.Black;
            StackPanel stackpanel = sender as StackPanel;
            TextBlock textblock = stackpanel.FindName("itemname") as TextBlock;
            //textblock.Foreground = mySolidColorBrush1;
        }
    }
}
