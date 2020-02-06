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
        public string Numero { get; set; }
        public TipoInscricao TipoInscricao { get; protected set; }

        public Documento(string numero)
        {
            Numero = numero;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Numero))
                throw new Exception("O CNPJ é inválido!\n Altere e salve novamente");

            TipoInscricao = Tipo;
            if (TipoInscricao == TipoInscricao.Júridica)
            {
                if (!CNPJ.IsValid(Numero))
                    throw new Exception("O CNPJ é inválido!\n Altere e salve novamente");
            }
            else
            {
                if (!CPF.IsValid(Numero))
                    throw new Exception("O CPF é inválido!\n Altere e salve novamente");

            }

        }
        public TipoInscricao Tipo
        {
            get
            {
                switch (Numero.Number().Length)
                {
                    case 14:
                        return TipoInscricao.Júridica;
                    case 11:
                        return TipoInscricao.Física;
                    default:
                        return TipoInscricao.Outro;
                }
            }
        }

    }
}
