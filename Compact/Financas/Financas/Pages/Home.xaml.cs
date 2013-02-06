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

namespace Financas
{
    public partial class Home : PhoneApplicationPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Transacao(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/Pages/TelaCadastro.xaml", UriKind.Relative));
        }

        private void Categoria(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/Pages/NovaCategoria.xaml", UriKind.Relative));
        }

        private void Grafico(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/Pages/Chart.xaml", UriKind.Relative));
        }

        private void Export(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/Pages/Export.xaml", UriKind.Relative));
        }

        private void Historico(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/Pages/MainPage.xaml", UriKind.Relative));
        }



    }
}