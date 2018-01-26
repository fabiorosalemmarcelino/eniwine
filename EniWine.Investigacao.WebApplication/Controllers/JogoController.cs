using EniWine.Investigacao.Library.Model;
using EniWine.Investigacao.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EniWine.Investigacao.WebApplication.Controllers
{
    public class JogoController : Controller
    {
        protected void CarregarDropDownList()
        {
            SuspeitoService suspeitoService = new SuspeitoService();
            LocalService localService = new LocalService();
            ArmaService armaService = new ArmaService();

            ViewBag.Suspeitos = new SelectList(suspeitoService.List(), "Id", "Nome");
            ViewBag.Locais = new SelectList(localService.List(), "Id", "Nome");
            ViewBag.Armas = new SelectList(armaService.List(), "Id", "Nome");
        }

        protected void SortearCrime()
        {
            CrimeService crimeService = new CrimeService();
            Session["Crime"] = crimeService.Sortear();
        }

        public ActionResult Index()
        {
            this.SortearCrime();

            this.CarregarDropDownList();

            return View();
        }

        [HttpPost]
        public ActionResult Verificar(FormCollection collection)
        {
            try
            {
                Crime crimeSorteado = (Crime)Session["Crime"];

                //ViewBag.CrimeSorteado = String.Concat(crimeSorteado.Suspeito.Nome, "-", crimeSorteado.Local.Nome, "-", crimeSorteado.Arma.Nome);

                int suspeito = int.Parse(collection["Suspeito"]);
                int arma = int.Parse(collection["Arma"]);
                int local = int.Parse(collection["Local"]);

                JogoService service = new JogoService((Crime)Session["Crime"]);
                int resultado = service.VerificarTeoria(suspeito, arma, local);

                switch (resultado)
                {
                    case 1:
                        ViewBag.Mensagem = "O assassino está incorreto";
                        break;
                    case 2:
                        ViewBag.Mensagem = "O local está incorreto";
                        break;
                    case 3:
                        ViewBag.Mensagem = "A arma está incorreta";
                        break;
                    default:
                        return RedirectToAction("CasoSolucionado");                        
                }

                ViewBag.Resultado = resultado;

                this.CarregarDropDownList();

                return View("Index");
            }
            catch{
                return RedirectToAction("Index");
            }
        }

        public ActionResult CasoSolucionado()
        {
            return View();
        }
    }        
}
