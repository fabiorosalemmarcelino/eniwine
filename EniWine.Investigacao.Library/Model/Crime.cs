using EniWine.Investigacao.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniWine.Investigacao.Library.Model
{
    public class Crime
    {
        public Suspeito Suspeito { get; set; }
        public Arma Arma { get; set; }
        public Local Local { get; set; }
    }
}
