﻿using MediaLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

namespace MediaLibrary.View
{
    [Export]
    /// <summary>
    /// MediaDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class MediaDetailView : UserControl
    {
        public MediaDetailView()
        {
            InitializeComponent();
        }

        [Import]
        private MediaDetailViewModel ViewModel
        {
            get { return this.DataContext as MediaDetailViewModel; }
            set { this.DataContext = value; }
        }
    }
}
