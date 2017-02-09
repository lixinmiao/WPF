using Infrastructure;
using MediaLibrary.View;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    [ModuleExport(typeof(MediaLibraryModule))]
    public class MediaLibraryModule : IModule
    {
        private IRegionManager regionManager;

        [ImportingConstructor]
        public MediaLibraryModule(IRegionManager _regionManager)
        {

            regionManager = _regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(MediaLibraryMain));
        }
    }
}
