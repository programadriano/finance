
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using PhoneMVVM;

namespace Financas
{
    public partial class MainPage
    {
        private const string conn = @"isostore:/Financas.sdf";
        public MainPage()
        {
            InitializeComponent();

            IList<Cadastro> c = GetReceita();
            Receitas.ItemsSource = c;

            IList<Cadastro> d = GetDespesa();
            Despesa.ItemsSource = d;         

        }

        public IList<Cadastro> GetReceita()
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                IList<Cadastro> lista = null;
                IQueryable<Cadastro> query = ctx.Cadastros.Where(x => x.TipoCategoria == 2).OrderBy(cadastro => Name);

                if (query.Count() > 0)
                {
                    lista = query.ToList();
                }

                return lista;
            }

        }

        public IList<Cadastro> GetDespesa()
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                IList<Cadastro> lista = null;
                IQueryable<Cadastro> query = ctx.Cadastros.Where(x => x.TipoCategoria == 1).OrderBy(cadastro => Name);
                if (query.Count() > 0)
                {
                    lista = query.ToList();
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