using Lifesys.Services.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lifesys.Teste
{
    [TestClass]
    public class Service
    {
        [TestMethod]
        public void ValidaData()
        {
            var data = new DateTime(1991, 6, 13);
            Assert.IsTrue(data.MaiorIdade());
        }

        [TestMethod]
        public void ValidaDataMenor()
        {
            var data = new DateTime(2009, 6, 13);
            Assert.IsTrue(data.MaiorIdade());
        }
        [TestMethod]
        public void ValidaData18()
        {
            var data = new DateTime(2002, 6, 13);
            Assert.IsTrue(data.MaiorIdade());
        }
    }
}
