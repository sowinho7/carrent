using DataAccessLayer.Core.Interfaces.UoW;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarRental.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IUnitOfWork uow, ILoggerFactory loggerFactory) : base(uow, loggerFactory)
        {
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult LikwidacjaSzkod()
        {
            ViewData["Message"] = "Your likwidacja szkod.";

            return View();
        }
        public IActionResult PomocDrogowa()
        {
            ViewData["Message"] = "Your pomoc drogowa.";

            return View();
        }
        public IActionResult BlachLak()
        {
            ViewData["Message"] = "Blacharsko lakiernicze.";

            return View();
        }
        public IActionResult Mechaniczne()
        {
            ViewData["Message"] = "Mechaniczne.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Gallery()
        {
            ViewData["Message"] = "Your gallery page.";

            return View();
        }
        public IActionResult Menu()
        {
            

            return View();
        }
        [HttpGet]
        public ActionResult ServicesInfo()
        {
            
            return PartialView("ServicesInfo");
        }
    }
}
