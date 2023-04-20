using MvcStock.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStock.Controllers
{
    public class YardimController : Controller
    {
        // GET: Yardim
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}