using Lifesys.Domain.ObjectValues;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lifesys.Domain.Entity
{
    public class Fornecedor : Shared.Entity.BaseEntity
    {
        public string Nome { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Documento Documento { get; set; }
        public Fornecedor()
        {

        }
        public Fornecedor(long id, string nome, long empresaId, Documento documento)
        {
            Id = id;
            Nome = nome;
            EmpresaId = empresaId;
            Documento = documento;
        }

        public override void Validar()
        {
            Documento.Validar();
        }
    }
}
