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

        protected void BindDropDownList()
        {
            SuspeitoService suspeitoService = new SuspeitoService();
            LocalService localService = new LocalService();
            ArmaService armaService = new ArmaService();

            ViewBag.Suspeitos = new SelectList(suspeitoService.List(), "Id", "Nome");
            ViewBag.Locais = new SelectList(localService.List(), "Id", "Nome");
            ViewBag.Armas = new SelectList(armaService.List(), "Id", "Nome");
        }

        public ActionResult Index()
        {
            this.BindDropDownList();

            return View();
        }

        [HttpPost]
        public ActionResult Verificar(FormCollection collection)
        {
            try
            {
                int suspeito = int.Parse(collection["Suspeito"]);
                int arma = int.Parse(collection["Arma"]);
                int local = int.Parse(collection["Local"]);

                JogoService service = new JogoService();
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
                        ViewBag.Mensagem = "Você solucionou o caso";
                        break;
                }

                ViewBag.Resultado = resultado;
                this.BindDropDownList();

                return View("Index");
            }
            catch{
                return RedirectToAction("Index");
            }
        }
    }        
}
