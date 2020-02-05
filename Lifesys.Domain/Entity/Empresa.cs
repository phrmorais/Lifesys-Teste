using Lifesys.Domain.Listed;
using Lifesys.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifesys.Domain.Entity
{
    public class Empresa : Shared.Entity.Entity
    {
        private IList<Fornecedor> _fornecedores;
        public Uf Uf { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }
        public virtual IReadOnlyCollection<Fornecedor> Fornecedores { get { return _fornecedores.ToArray(); } }

        public Empresa(long id, Uf uf, string nomeFantasia, string cnpj) : base(id)
        {
            Uf = uf;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            _fornecedores = new List<Fornecedor>();
        }
    }
}
