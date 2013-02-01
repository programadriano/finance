using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Controls;

namespace TwoUIt.QuantoEstouPoupando.Utils
{
    /// <summary>
    /// Extensions for String type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// It transforms any string that contains at least one number into a decimal
        /// </summary>
        /// <param name="str">String that will be transformed to a decimal</param>
        /// <returns>Decimal converted from string</returns>
        public static decimal ToDecimal(this string str)
        {
            decimal res = 0;

            if (!String.IsNullOrEmpty(str))
            {
                str = Regex.Replace(str, @"[^\d]*", String.Empty);
                str = String.Concat("000", str);
                CultureInfo cc = CultureInfo.CurrentCulture;
                string decimalSeparator = cc.NumberFormat.CurrencyDecimalSeparator;

                int tam = str.Length - 2;
                str = String.Format("{0}{1}{2}", str.Substring(0, tam), decimalSeparator, str.Substring(tam, 2));

                decimal.TryParse(str, out res);
            }
            return res;
        }

    }
}


/// Implementação


//private void FormatTextBox(TextBox txt, bool isPercentage)
//{
//    if (txt != null)
//    {
//        string specifier = isPercentage ? "P" : "C";
//        decimal value = txt.Text.ToDecimal();
//        CultureInfo pt = new CultureInfo("pt-br");

//        if(isPercentage)
//            value /= 100;

//        txt.Text = value.ToString(specifier, _pt);

//        int start = isPercentage ? txt.Text.Length - 1 : txt.Text.Length;

//        txt.Select(start, 0);
//    }
//}
