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
    public class ArmaServiceTests
    {
        [TestMethod()]
        public void ObterPorIdTest()
        {
            ArmaService service = new ArmaService();
            Arma obtida = service.Find(1);

            Assert.IsTrue(obtida.Nome=="Cajado Devastador");
        }
    }
}