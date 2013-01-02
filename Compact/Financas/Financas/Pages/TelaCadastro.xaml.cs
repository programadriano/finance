using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using PhoneMVVM;

namespace Financas
{
    public partial class TelaCadastro
    {
        private const string conn = @"isostore:/Financas.sdf";

        public TelaCadastro()
        {
            InitializeComponent();
            //List<Categoria> c = new List<Categoria>();
            //this.ListPickerSub.ItemsSource = c;         
            rDespesa.IsChecked = true;

            parcela.Visibility = Visibility.Collapsed;
            tboxParcelas.Visibility = Visibility.Collapsed;

            IList<Categoria> c = GetCategorias();
            // StringBuilder texto = new StringBuilder();
            this.ListPickerSub.ItemsSource = c;
        }

        public IList<Categoria> GetCategorias()
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                IList<Categoria> lista = null;
                IQueryable<Categoria> query = ctx.Categorias.OrderBy(categoria => Name);
                lista = query.ToList();
                return lista;
            }

        }

        public void Button1Click(object sender, EventArgs eventArgs)
        {
            this.Focus();
        }

        public void Button2Click(object sender, EventArgs eventArgs)
        {
            // MessageBox.Show("Add Mano!");
            NavigationService.Navigate(
               new Uri("/Pages/Home.xaml", UriKind.Relative));
        }

        public void Salvar(object sender, EventArgs eventArgs)
        {
            //String _Content = String.Format("Categoria: {0},Despesa: {1},Receita: {2},Valor: {3},Data: {4}",
            //   ListPickerSub.SelectedItems, rDespesa.IsChecked.Value, rReceita.IsChecked.Value, xValor.Text, xData.Value);
            //MessageBox.Show(_Content);

            using (var ctx = new FinancasDataContext(conn))
            {
                var cat = new Categoria();
                cat = ListPickerSub.SelectedItem as Categoria;

                var cadastro = new Cadastro
                                   {
                                       Descricao = xDescricao.Text,
                                       CategoriaId = cat.Id,
                                       Valor = Convert.ToDouble(xValor.Text),
                                       Data = xData.Value,
                                       TipoCategoria = (rReceita.IsChecked.Value) ? 1 : 2,
                                       Parcelas = parcela.Text != "" ? Convert.ToInt32(parcela.Text) : 0

                                   };

                ctx.Cadastros.InsertOnSubmit(cadastro);
                ctx.SubmitChanges();
            }

            MessageBox.Show("Registro salvo com sucesso!");
            NavigationService.Navigate(
               new Uri("/Pages/MainPage.xaml", UriKind.Relative));
        }

        public void ValorCategoria(object sender, RoutedEventArgs e)
        {
            string _Content = string.Format("nCategoria: {0}",
               ListPickerSub.SelectedItem);
            MessageBox.Show(_Content);
        }

        private void InputBoxKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Focus();
                //enter has been pressed
            }
        }

        private void AddCategoria(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
              new Uri("/Pages/NovaCategoria.xaml", UriKind.Relative));
        }

        private void AddParcelas(object sender, RoutedEventArgs e)
        {
            parcela.Visibility = Visibility.Visible;
            tboxParcelas.Visibility = Visibility.Visible;
        }

        private void removeParcelas(object sender, RoutedEventArgs e)
        {
            parcela.Visibility = Visibility.Collapsed;
            tboxParcelas.Visibility = Visibility.Collapsed;
        }


    }
}