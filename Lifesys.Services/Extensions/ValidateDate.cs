using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Services.Extensions
{
    public static class ValidateDate
    {
        public static bool MaiorIdade(this DateTime date)
        {
            var ano = DateTime.Now.Date.Year - date.Year;
            if (ano < 18) return false;
            if (ano == 18)
            {
                var meses = DateTime.Now.Date.Month - date.Month;
                if (meses < 0) return false;

                if (meses == 0)
                {
                    var dias = DateTime.Now.Date.Day - date.Day;
                    if (dias < 0) return false;
                }
            }

            return true;
        }
    }
}
