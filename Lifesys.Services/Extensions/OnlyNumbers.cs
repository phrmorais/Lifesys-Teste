using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lifesys.Services.Extensions
{
    public static class OnlyNumbers
    {

        public static string Number(this string Valor)
        {
            string pattern = @"[^\d]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(Valor, replacement);

            return result;
        }
    }
}
