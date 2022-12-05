using OtoServis.BusinessLayer.Concrete;
using OtoServis.Entities.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoServis.WebUI.Controllers.Web
{
    [Authorize(Roles = "Admin")]
    public class IletisimController : Controller
    {
        private readonly Repository<Haritaletisim> rpIletisim = new Repository<Haritaletisim>();
        // GET: Iletisim
        public ActionResult Index()
        {
            if (rpIletisim.List().Count==0)
            {
                Haritaletisim hi = new Haritaletisim();
                hi.Harita = "-";
                hi.Iletisim = "-";
                hi.Unvan = "-";
                rpIletisim.Insert(hi);
            }
            var iletisim = rpIletisim.List().FirstOrDefault();
            return View(iletisim);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Kaydet(Haritaletisim iletisimx)
        {
            var guncellenecek = rpIletisim.GetById(iletisimx.HaritaIletisimId);
            guncellenecek.Harita = iletisimx.Harita;
            guncellenecek.Iletisim = iletisimx.Iletisim;
            guncellenecek.Unvan = iletisimx.Unvan;
            rpIletisim.Update(guncellenecek);
            return RedirectToAction("Index");
        }
    }
}