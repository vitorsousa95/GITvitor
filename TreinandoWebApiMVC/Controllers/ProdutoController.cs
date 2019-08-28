using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinandoWebApiMVC.Models;

namespace TreinandoWebApiMVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Produto viewProduto)
        {
            return View();
        }
    }
}