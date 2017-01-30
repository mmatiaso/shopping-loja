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
    public class ModuleController : Controller
    {
        private shoppingxEntities db = new shoppingxEntities();
        
        //
        // GET: /Module/

        public ActionResult Menu()
        {
            List<Categoria> cats = new List<Categoria>();
            cats = db.Categorias.ToList();
            return View(cats);
        }

        public ActionResult MenuLojas()
        {
            List<Loja> ljs = new List<Loja>();
            ljs = db.Lojas.ToList();
            return View(ljs);
        }

        public ActionResult TopOferta(int catid, string k, int result, int page, string sort="")
        {
            Subcategoria s = new Subcategoria();
            if (db.Subcategorias.Where(a => a.LomadeeId == catid).Any() && catid > 0)
            {
                s = db.Subcategorias.Where(a => a.LomadeeId == catid).First();
            }
            ViewData["k"] = k;
            ViewData["result"] = result;
            return View(s);
        }

        public ActionResult TopOferta2(int catid, string k, int result, int page, string sort = "")
        {
            Subcategoria s = new Subcategoria();
            if (db.Subcategorias.Where(a => a.LomadeeId == catid).Any() && catid > 0)
            {
                s = db.Subcategorias.Where(a => a.LomadeeId == catid).First();
            }
            ViewData["k"] = k;
            ViewData["result"] = result;
            return View(s);
        }

    }
}
