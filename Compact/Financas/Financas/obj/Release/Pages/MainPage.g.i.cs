﻿#pragma checksum "C:\Users\adriano\Documents\GitHub\finance\Compact\Financas\Financas\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2603760B181F34DE8E86404896380696"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using C1.Phone.FlexGrid;
using Microsoft.Phone.Controls;
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


namespace Financas {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal C1.Phone.FlexGrid.C1FlexGrid flexgridReceita;
        
        internal C1.Phone.FlexGrid.C1FlexGrid flexgrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Financas;component/Pages/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.flexgridReceita = ((C1.Phone.FlexGrid.C1FlexGrid)(this.FindName("flexgridReceita")));
            this.flexgrid = ((C1.Phone.FlexGrid.C1FlexGrid)(this.FindName("flexgrid")));
        }
    }
}

