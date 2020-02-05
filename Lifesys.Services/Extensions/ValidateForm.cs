using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifesys.Services.Extensions
{

    public static class ValidateForm
    {
        public static Form Validate<T>(this FormCollection forms) where T : Form
        {
          return forms
                 .OfType<T>()
                 .FirstOrDefault();
            //return form;
        }
    }
}
