﻿#pragma checksum "C:\Users\adriano\documents\visual studio 2010\Projects\Financas\Financas\Cadastro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A9E9BEE37F4EDB303D467BC77E4D7A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class Cadastros : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox xDescricao;
        
        internal System.Windows.Controls.TextBox xValor;
        
        internal Microsoft.Phone.Controls.ListPicker ListPickerSub;
        
        internal Microsoft.Phone.Controls.DatePicker xData;
        
        internal System.Windows.Controls.RadioButton rDespesa;
        
        internal System.Windows.Controls.RadioButton rReceita;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Financas;component/Cadastro.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.xDescricao = ((System.Windows.Controls.TextBox)(this.FindName("xDescricao")));
            this.xValor = ((System.Windows.Controls.TextBox)(this.FindName("xValor")));
            this.ListPickerSub = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("ListPickerSub")));
            this.xData = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("xData")));
            this.rDespesa = ((System.Windows.Controls.RadioButton)(this.FindName("rDespesa")));
            this.rReceita = ((System.Windows.Controls.RadioButton)(this.FindName("rReceita")));
        }
    }
}

