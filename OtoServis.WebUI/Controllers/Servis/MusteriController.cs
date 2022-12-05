using OtoServis.BusinessLayer.Concrete;
using OtoServis.Entities.Servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoServis.WebUI.Controllers.Servis
{
    public class MusteriController : Controller
    {
        private readonly Repository<Musteri> rpMusteri = new Repository<Musteri>();
        // GET: Musteri
        public ActionResult Index()
        {
            return View(rpMusteri.Get().OrderByDescending(x=>x.MusteriId).Take(20).ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Musteri musteri)
        {
            rpMusteri.Insert(musteri);
            TempData["Ok"] = "Müşteri Başarı ile Kaydedildi";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int musteriId)
        {
            var musteri = rpMusteri.GetById(musteriId);
            ViewBag.Title = musteri.AdSoyad + " Düznleme";
            return View(musteri);
        }
        [HttpPost]
        public ActionResult Edit(Musteri musteri)
        {
            var guncelle = rpMusteri.GetById(musteri.MusteriId);
            guncelle.AdSoyad = musteri.AdSoyad;
            guncelle.Telefon = musteri.Telefon;
            guncelle.Eposta = musteri.Eposta;
            guncelle.Adres = musteri.Adres;
            rpMusteri.Update(guncelle);
            TempData["Ok"] = guncelle.AdSoyad + " müşterisi başarı ile güncellenmiştir.";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult MusteriSil(int id)
        {
            var silinecek = rpMusteri.GetById(id);
            rpMusteri.Delete(silinecek);
            TempData["Ok"] = "Müşteri Başarı ile silindi.";
            return RedirectToAction("Index");
        }
    }
}