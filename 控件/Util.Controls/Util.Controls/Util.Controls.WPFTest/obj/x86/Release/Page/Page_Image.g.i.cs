﻿#pragma checksum "..\..\..\..\Page\Page_Image.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5B4EA8287DB32504E6D12DCFC4CF4A58"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using XLY.Framework.Controls;


namespace XLY.Framework.WPFTest {
    
    
    /// <summary>
    /// Page_Image
    /// </summary>
    public partial class Page_Image : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\Page\Page_Image.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal XLY.Framework.Controls.ThumbnailImage ImageCache;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Page\Page_Image.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal XLY.Framework.Controls.AnimatedGIF Gif;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Page\Page_Image.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gifSource;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XLY.Framework.WPFTest;component/page/page_image.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\Page_Image.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 38 "..\..\..\..\Page\Page_Image.xaml"
            ((XLY.Framework.Controls.FButton)(target)).Click += new System.Windows.RoutedEventHandler(this.FButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ImageCache = ((XLY.Framework.Controls.ThumbnailImage)(target));
            return;
            case 3:
            this.Gif = ((XLY.Framework.Controls.AnimatedGIF)(target));
            return;
            case 4:
            this.gifSource = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 44 "..\..\..\..\Page\Page_Image.xaml"
            ((XLY.Framework.Controls.FButton)(target)).Click += new System.Windows.RoutedEventHandler(this.FButton_StartClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 45 "..\..\..\..\Page\Page_Image.xaml"
            ((XLY.Framework.Controls.FButton)(target)).Click += new System.Windows.RoutedEventHandler(this.FButton_EndClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

