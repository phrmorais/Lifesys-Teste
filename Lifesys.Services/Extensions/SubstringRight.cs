using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Services.Extensions
{
    public static class SubstringRight
    {
        public static string Right(this string value, int length)
        {
            string Retorno = "";
            if ((value.Length - length) > 0)
                Retorno = value.Substring(value.Length - length);

            return Retorno;
        }
    }
}
