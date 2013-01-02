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

namespace Financas.Pages
{
    public partial class Chart : PhoneApplicationPage
    {
        private const string conn = @"isostore:/Financas.sdf";
        public Chart()
        {
            InitializeComponent();

            // Clear previous data
            C1Chart1.Data.Children.Clear();
            //IList<string> ProductNames = new List<string>();
            //IList<int> PriceX = new List<int>(); ;
            //using (var ctx = new FinancasDataContext(conn))
            //{               
            //    IQueryable<Cadastro> query = ctx.Cadastros.OrderBy(cadastro => Name);

            //    foreach (var item in query)
            //    {
            //        ProductNames.Add(item.Descricao);
            //        PriceX.Add(Convert.ToInt32(item.Valor));
            //    }
            //}
            //            // Add Data
            string[] ProductNames = { "Café", "Almoço", "Combustivel", 
     "Lazer", "Curso", "Condução", "Material", "Academia" };
            int[] PriceX = { 80, 400, 20, 60, 150, 300, 130, 500 };
            // create single series for product price
            DataSeries ds1 = new DataSeries();
            ds1.Label = "Price X";
            //set price data
            ds1.ValuesSource = PriceX;
            // add series to the chart
            C1Chart1.Data.Children.Add(ds1);
            // add item names
            C1Chart1.Data.ItemNames = ProductNames;
            // Set chart type
            C1Chart1.ChartType = ChartType.Bar;
        }
    }
}