using System.Web.Mvc;

namespace CreditMarket.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public ActionResult NavigateToOrder()
        {
            return RedirectToAction("Create", "Orders");
        }

        public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}