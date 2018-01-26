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
    public class SuspeitoServiceTests
    {
        [TestMethod()]
        public void ObterPorIdTest()
        {
            SuspeitoService service = new SuspeitoService();
            Suspeito obtido = service.Find(1);

            Assert.IsTrue(obtido.Nome == "Esqueleto");
        }
    }
}