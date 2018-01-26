using Microsoft.VisualStudio.TestTools.UnitTesting;
using EniWine.Investigacao.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EniWine.Investigacao.Library.Model;

namespace EniWine.Investigacao.Library.Services.Tests
{
    [TestClass()]
    public class CrimeServiceTests
    {
        [TestMethod()]
        public void SortearTest()
        {
            CrimeService service = new CrimeService();
            Crime crime = service.Sortear();
            Assert.IsTrue(crime.Arma!=null);
            Assert.IsTrue(crime.Local != null);
            Assert.IsTrue(crime.Suspeito != null);
        }
    }
}