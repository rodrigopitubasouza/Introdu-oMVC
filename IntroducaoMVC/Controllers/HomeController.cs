using System.Web.Mvc;
using IntroducaoMVC.Models;

namespace IntroducaoMVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            Pessoa pessoa = new Pessoa(1,"Rodrigo Pituba de Souza","Administrador");
            return View(pessoa);
        }
        

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contatos() {
            ViewBag.Message = "Contato de exemplo.";

            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa) {
            
            return View(pessoa);
        }
    }
}