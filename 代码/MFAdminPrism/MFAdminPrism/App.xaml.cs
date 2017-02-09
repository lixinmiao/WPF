using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MFAdminPrism
{
    /// <summary>
    /// App.xaml 的交互逻辑,程序启动
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MFAdminBootstrapper bootstrapper = new MFAdminBootstrapper();
            bootstrapper.Run();
        }
    }
}
