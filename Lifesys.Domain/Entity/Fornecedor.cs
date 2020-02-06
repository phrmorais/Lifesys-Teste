using Lifesys.Domain.ObjectValues;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lifesys.Domain.Entity
{
    public class Fornecedor : Shared.Entity.Entity
    {
        public string Nome { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Documento Documento { get; set; }

        public override void Validar()
        {
            
         
        }
    }
}
