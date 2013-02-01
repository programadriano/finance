
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using PhoneMVVM;
using System.Windows.Media;

namespace Financas
{
    public partial class MainPage
    {
        private const string conn = @"isostore:/Financas.sdf";
        public MainPage()
        {
            InitializeComponent();
            var c = GetReceita();
            flexgridReceita.ItemsSource = c;
            var col = flexgridReceita.Columns["Key"];
            col.Header = "Descrição";
            var value = flexgridReceita.Columns["value"];
            value.Header = "Valor";
            // col. = new SolidColorBrush(Colors.Blue);


            var d = GetDespesa();
            flexgrid.ItemsSource = d;
            var key = flexgrid.Columns["Key"];
            key.Header = "Descrição";
            var valor = flexgrid.Columns["value"];
            valor.Header = "Valor";
        }

        public Dictionary<string, string> GetReceita()
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                Dictionary<string, string> lista = new Dictionary<string, string>();

                IQueryable<Cadastro> query = ctx.Cadastros.Where(x => x.TipoCategoria == 2).OrderBy(cadastro => Name);

                if (query.Count() > 0)
                {
                    foreach (var item in query.ToList())
                    {                       
                        lista.Add(item.Descricao, item.Preco);
                    }
                }
                return lista;
            }

        }

        public Dictionary<string, string> GetDespesa()
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                Dictionary<string, string> lista = new Dictionary<string, string>();

                IQueryable<Cadastro> query = ctx.Cadastros.Where(x => x.TipoCategoria == 1).OrderBy(cadastro => Name);

                if (query.Count() > 0)
                {
                    foreach (var item in query.ToList())
                    {
                        lista.Add(item.Descricao, item.Preco);
                    }
                }
                return lista;
            }

        }

        public void Button1Click(object sender, EventArgs eventArgs)
        {
            // MessageBox.Show("Add Mano!");
            NavigationService.Navigate(
               new Uri("/Pages/TelaCadastro.xaml", UriKind.Relative));
        }



    }


}