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

namespace Financas.Pages
{
    public partial class Transacao : PhoneApplicationPage
    {
        public Transacao()
        {
            InitializeComponent();
            Title();
        }

        public void Title() 
        {
            var month = DateTime.Now.ToString("MMMM");
            ApplicationTitle.DataContext = UppercaseFirst(month);
            
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}