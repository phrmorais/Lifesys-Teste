using Lifesys.Domain.Listed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Domain.ObjectValues
{
    public class Documento
    {
        public string NumDoc { get; private set; }
        public TipoInscricao TipoInscricao { get; private set; }

        public Documento(string numDoc, TipoInscricao tipoInscricao)
        {
            NumDoc = numDoc;
            TipoInscricao = tipoInscricao;
        }
    }
}
