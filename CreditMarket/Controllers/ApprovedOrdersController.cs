using CreditMarket.Models;
using CreditMarket.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CreditMarket.Controllers
{
    public class ApprovedOrdersController : Controller
    {
        private readonly UnionsDbContext _context;

        public ApprovedOrdersController()
        {
            _context = new UnionsDbContext();
        }
        // GET: ApprovedOrders
        public ActionResult Index()
        {
            var approvedOrders = _context.ApprovedOrders.ToList();
            return View(approvedOrders);
        }

        [HttpGet]
        public ActionResult DetailedInfo(int id)
        {

            var approvedOrder = _context.ApprovedOrders.SingleOrDefault(o => o.Id == id);

            if (approvedOrder == null)
                return HttpNotFound();

            var viewModel = new ApprovedOrderFormViewModel
            {
                ApprovedOrder = approvedOrder,
            };

            return View("DetailedInfo", viewModel);
        }
    }
}