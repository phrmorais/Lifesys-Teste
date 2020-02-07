using Lifesys.Domain.Listed;
using Lifesys.Shared.Entity;
using Sirb.Documents.BR.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Domain.Entity
{
    public class Empresa : BaseEntity
    {
        public Uf Uf { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public virtual IList<Fornecedor> Fornecedores { get; set; }
        public Empresa()
        {

        }
        public Empresa(long id, Uf uf, string nomeFantasia, string cnpj)
        {
            Id = id;
            Uf = uf;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
        }

        public override void Validar()
        {
            if (!CNPJ.IsValid(Cnpj))
                throw new Exception("O CNPJ é inválido!\n Altere e salve novamente");
        }
    }
}
