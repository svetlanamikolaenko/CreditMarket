using CreditMarket.Models;
using CreditMarket.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CreditMarket.Controllers
{
	public class OrdersController : Controller
	{
		private readonly ApplicationDbContext _context;

		public OrdersController()
		{
			_context = new ApplicationDbContext();
		}
		// GET: Orders
		public ActionResult Create()
		{
			var viewModel = new OrderFormViewModel
			{
				Loans = _context.Loans.ToList()
			};
			return View(viewModel);
		}
	}
}