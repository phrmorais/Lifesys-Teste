using Lifesys.Domain.ObjectValues;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lifesys.Domain.Entity
{
    public class Fornecedor : Shared.Entity.Entity
    {
        public string Nome { get; private set; }
        public virtual Empresa Empresa { get; private set; }
        public virtual Documento Documento { get; set; }

        public Fornecedor(long id, string nome, Documento documento) : base(id)
        {
            Nome = nome;
            Documento = documento;
        }
    }
}
