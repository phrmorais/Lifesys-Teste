using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifesys.Services.Extensions
{
    public static class OpenForm
    {
        public static void Open(this Form form)
        {
            form.Show();
            form.Focus();
        }
    }
}
