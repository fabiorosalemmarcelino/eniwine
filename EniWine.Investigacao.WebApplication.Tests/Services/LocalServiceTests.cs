using Microsoft.VisualStudio.TestTools.UnitTesting;
using EniWine.Investigacao.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EniWine.Investigacao.Library.Models;

namespace EniWine.Investigacao.Library.Services.Tests
{
    [TestClass()]
    public class LocalServiceTests
    {
        [TestMethod()]
        public void ObterPorIdTest()
        {
            LocalService service = new LocalService();
            Local obtido = service.Find(1);

            Assert.IsTrue(obtido.Nome == "Etérnia");
        }
    }
}