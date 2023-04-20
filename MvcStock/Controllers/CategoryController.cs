using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MvcStock.Models.Entity;
using Newtonsoft.Json;
using PagedList;
using PagedList.Mvc;

namespace MvcStock.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index(int sayfa=1)
        {
            //var degerler = db.TBLKATEGORILERs.ToList();
            var degerler = db.TBLKATEGORILERs.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.TBLKATEGORILERs.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var kategori = db.TBLKATEGORILERs.Find(id);
            db.TBLKATEGORILERs.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.TBLKATEGORILERs.Find(id);
            return View("KategoriGetir", ktgr);
        }
        [HttpGet]
        public ActionResult Guncelle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guncelle(TBLKATEGORILER p1)
        {
            var ktg = db.TBLKATEGORILERs.Find(p1.KATEGORIID);
            ktg.KATEGORIAD = p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}