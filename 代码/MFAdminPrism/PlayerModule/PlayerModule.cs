

using System;
using Infrastructure;
using System.ComponentModel.Composition;
using Player.View;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Player
{
    /// <summary>
    /// Module定义
    /// </summary>
    [ModuleExport(typeof(PlayerModule))]
    public class PlayerModule : IModule
    {     
        private IRegionManager regionManager;
        [ImportingConstructor]
        public PlayerModule(IRegionManager _regionManager)
        { 
            regionManager = _regionManager;
        }
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(PlayerMain));
        }
    }
}
