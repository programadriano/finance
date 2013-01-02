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
using PhoneMVVM;

namespace Financas
{
    public partial class NovaCategoria : PhoneApplicationPage
    {
        private const string conn = @"isostore:/Financas.sdf";
        public NovaCategoria()
        {
            InitializeComponent();
        }

        public void Salvar(object sender, EventArgs eventArgs)
        {
            using (var ctx = new FinancasDataContext(conn))
            {
                var categoria = new Categoria
                                    {
                                        Nome = xCategoria.Text,
                                    };
                ctx.Categorias.InsertOnSubmit(categoria);
                ctx.SubmitChanges();
            }


            var m = MessageBox.Show("Registro salvo com sucesso! Deseja cadastrar mais uma categoria ?", "File Save", MessageBoxButton.OKCancel);

            if (m == MessageBoxResult.OK)
            {
                Focus();
            }
            else if (m == MessageBoxResult.Cancel)
            {
                NavigationService.GoBack();
            }
            {

            }
        }

        public void Cancelar(object sender, EventArgs eventArgs)
        {
            NavigationService.GoBack();
        }
    }
}