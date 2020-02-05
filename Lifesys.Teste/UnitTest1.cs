using System;
using System.Linq;
using Lifesys.Infrastructure.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lifesys.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConectaBanco()
        {
          var  we = new LifesysContext();
            var list = we.Fornecedores.ToList();
        }
    }
}
