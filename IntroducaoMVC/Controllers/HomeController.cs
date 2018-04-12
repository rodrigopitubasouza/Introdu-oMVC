using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroducaoMVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contatos() {
            ViewBag.Message = "Contato de exemplo.";

            return View();
        }

        
    }
}