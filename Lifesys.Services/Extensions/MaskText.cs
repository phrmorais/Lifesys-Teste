using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifesys.Services.Extensions
{
   public static class MaskText
    {
        public static void MaskCnpjCpf(this TextBox Item)
        {
            if (string.IsNullOrEmpty(Item.Text)) return;
            string valor;
            if (Item.Text.Number().Length <= 11)
            {
                valor = ("00000000000" + Item.Text.Number()).Right(11);
                valor = valor.Substring(0, 3) + "." + valor.Substring(3, 3) + "." + valor.Substring(6, 3) + "-" +
                        valor.Substring(9, 2);
            }
            else
            {
                valor = ("00000000000000" + Item.Text.Number()).Right(14);
                valor = valor.Substring(0, 2) + "." + valor.Substring(2, 3) + "." + valor.Substring(5, 3) + "/" +
                        valor.Substring(8, 4) + "." + valor.Substring(12, 2);
            }

            Item.Text = valor;
        }
    }
}
