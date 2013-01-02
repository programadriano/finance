using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using C1.Phone.Chart;
using Microsoft.Phone.Shell;

namespace ControlExplorer.Controls.Chart
{
    public partial class Labels
        : UserControl
    {
        public Labels()
        {
            InitializeComponent();

            c1chart.BeginUpdate();
            c1chart.View.AxisY.Min = 0;
            c1chart.View.AxisY.Max = 10;            
            c1chart.EndUpdate();



      

        }
    }
}

