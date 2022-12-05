using OtoServis.BusinessLayer.Concrete;
using OtoServis.Entities.Web;
using System.Linq;
using System.Web.Mvc;

namespace OtoServis.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository<Slider> rpSlider = new Repository<Slider>();
        private readonly Repository<Kampanya> rpKampanya = new Repository<Kampanya>();
        private readonly Repository<Uygulama> rpUygulama = new Repository<Uygulama>();
        private readonly Repository<Hakkimizda> rpHakiimizda = new Repository<Hakkimizda>();
        private readonly Repository<Blog> rpBlog = new Repository<Blog>();
        private readonly Repository<Haritaletisim> rpIletisim = new Repository<Haritaletisim>();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Slider = rpSlider.List();
            ViewBag.Kampanya = rpKampanya.List().FirstOrDefault();
            ViewBag.Uygulama = rpUygulama.List();
            ViewBag.Hakkimizda = rpHakiimizda.List().FirstOrDefault();
            ViewBag.Blog = rpBlog.List().OrderByDescending(x => x.BlogId).Take(4).ToList();
            ViewBag.Harita = rpIletisim.List().FirstOrDefault();
            ViewBag.Adress = rpIletisim.List().FirstOrDefault().Iletisim;

            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Deneme()
        {
            return View();
        }
        [Route("{baslik}/{BlogId:int}")]
        public ActionResult BlogDetay(string baslik, int blogId)
        {
            var detay = rpBlog.GetById(blogId);
            ViewBag.Adress = rpIletisim.List().FirstOrDefault().Iletisim;
            return View(detay);
        }
    }
}
