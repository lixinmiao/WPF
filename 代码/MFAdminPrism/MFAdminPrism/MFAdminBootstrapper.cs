/* ==============================================================================
 * 功能描述：MFAdminBootstrapper  
 * 创 建 者：lixinmiao
 * 创建日期：2017/1/16 12:14:16
 * ==============================================================================*/
using MediaLibrary;
using Microsoft.Practices.Prism.MefExtensions;
using Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Windows;
using Template;

namespace MFAdminPrism
{
    /// <summary>
    /// MFAdminBootstrapper
    /// </summary>
    public class MFAdminBootstrapper:MefBootstrapper
    {
        /// <summary>
        /// 返回你应用程序Shell类的实例，可以根据需求选择创建Shell对象或者从Container中获取Shell。
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        /// <summary>
        /// 创建Shell之后显示之前，需要为应用程序设置主界面。
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        /// 注册程序集
        /// </summary>
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            //加载自己
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(this.GetType().Assembly));

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(PlayerModule).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MediaLibraryModule).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(TemplateModule).Assembly));
        }
    }
}