using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shoppingx.Models;

namespace shoppingx.Controllers
{
    public class HomeController : Controller
    {

        private shoppingxEntities db = new shoppingxEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Lojas(int s)
        {
            Loja l = new Loja();
            if (db.Lojas.Where(a => a.LomadeeId == s).Any())
            {
                l = db.Lojas.Where(a => a.LomadeeId == s).First();
            }
            return View(l);
           
        }

        public ActionResult Ofertas(int c)
        {
            Subcategoria s = new Subcategoria();
            if (db.Subcategorias.Where(a => a.LomadeeId == c).Any())
            {
                s = db.Subcategorias.Where(a => a.LomadeeId == c).First();
            }
            return View(s);
        }

        public ActionResult Produto(int id)
        {
            Produto prod = new Produto();
            if (db.Produtoes.Where(a => a.LomadeeId == id).Any())
            {
                prod = db.Produtoes.Where(a => a.LomadeeId == id).First();
            }
            return View(prod);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
