using Lifesys.Domain.Entity;
using Lifesys.Domain.Listed;
using Lifesys.Shared.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirb.Documents.BR.Validation;
namespace Lifesys.Domain.Command
{
    public class CreateEmpresaCommand : ICommand
    {
        public Uf Uf { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        public void Validate()
        {
            //var validator = new /*CNPJ*/()
            if (!CNPJ.IsValid(Cnpj))
                throw new NotImplementedException();
        }
    }
}
