﻿#pragma checksum "C:\Users\thiagodasilva\Documents\GitHub\finance\Compact\Financas\Financas\Pages\Labels.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "067B4277EE63734909AA6BD2DCEC10BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using C1.Phone.Chart;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ControlExplorer.Controls.Chart {
    
    
    public partial class Labels : System.Windows.Controls.UserControl {
        
        internal C1.Phone.Chart.C1Chart c1chart;
        
        internal C1.Phone.Chart.C1ChartLegend legend;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Financas;component/Pages/Labels.xaml", System.UriKind.Relative));
            this.c1chart = ((C1.Phone.Chart.C1Chart)(this.FindName("c1chart")));
            this.legend = ((C1.Phone.Chart.C1ChartLegend)(this.FindName("legend")));
        }
    }
}

