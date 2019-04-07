using CreditMarket.Models;
using CreditMarket.ViewModels;
using System.Web.Mvc;

namespace CreditMarket.Controllers
{
	public class LoansController : Controller
	{
		private readonly ApplicationDbContext _context;

		public LoansController()
		{
			_context = new ApplicationDbContext();
		}

		[Authorize]
		public ActionResult Create()
		{
			return View();
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(LoanFormViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				return View("Create", viewModel);
			}

			var loan = new Loan
			{
				Name = viewModel.Name,
				Period = viewModel.Period,
				Procent = viewModel.Procent
			};

			_context.Loans.Add(loan);
			_context.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}