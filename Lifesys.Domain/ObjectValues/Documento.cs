using Lifesys.Domain.Listed;
using Lifesys.Services.Extensions;
using Sirb.Documents.BR.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Domain.ObjectValues
{
    public class Documento
    {
        public string NumDoc { get; set; }
        public TipoInscricao TipoInscricao { get; protected set; }
        public void Validar()
        {
            if (string.IsNullOrEmpty(NumDoc))
                throw new Exception("O CNPJ é inválido!\n Altere e salve novamente");

            TipoInscricao = Tipo;
            if (TipoInscricao == TipoInscricao.CNPJ)
            {
                if (!CNPJ.IsValid(NumDoc))
                    throw new Exception("O CNPJ é inválido!\n Altere e salve novamente");
            }
            else
            {
                if (!CPF.IsValid(NumDoc))
                    throw new Exception("O CPF é inválido!\n Altere e salve novamente");

            }

        }
        public TipoInscricao Tipo
        {
            get
            {
                switch (NumDoc.Number().Length)
                {
                    case 14:
                        return TipoInscricao.CNPJ;
                    case 11:
                        return TipoInscricao.CPF;
                    default:
                        return TipoInscricao.Outro;
                }
            }
        }

    }
}
