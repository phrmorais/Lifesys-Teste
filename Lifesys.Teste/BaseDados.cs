using System;
using System.Linq;
using Lifesys.Infrastructure.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lifesys.Teste
{
    [TestClass]
    public class BaseDados
    {
        private LifesysContext _context;
        [TestMethod]
        public void VerificaEmpresa()
        {
            var _context = new LifesysContext();
            Assert.IsFalse(_context.Fornecedores.Any());
        }
    }
}
