using LojaRazor.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaRazor.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/

        public ActionResult Index()
        {
            DepartamentosDAO departamentosDAO = new DepartamentosDAO();
            ViewBag.Departamentos = departamentosDAO.Lista();
            return View();
        }

    }
}
