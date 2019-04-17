using CreditMarket.Models;
using CreditMarket.ViewModels;
using System;
using System.Data.Entity;
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

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		public ViewResult Index()
		{
			var orders = _context.Orders.Include(x => x.Loan).ToList();

			return View(orders);
		}

        public ActionResult Edit(int id)
        {
            var order = _context.Orders.Find(id);
            return View(order);
        }

        [Authorize]
		public ActionResult Create()
		{
			var viewModel = new OrderFormViewModel
			{
				Loan = _context.Loans.ToList()
			};
			return View(viewModel);
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(OrderFormViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				viewModel.Loan = _context.Loans.ToList();
				return View("Create", viewModel);
			}
			var order = new Order
			{
				Amount = viewModel.Amount,
				LoanId = viewModel.Order.LoanId,
				LastName = viewModel.LastName,
				FirstName = viewModel.FirstName,
				FathersName = viewModel.FathersName,
				DateOfBirth = viewModel.GetDateOfBirth(),
				Email = viewModel.Email,
				PhoneNumber = viewModel.PhoneNumber,
				INN = viewModel.INN,
				PassportNumber = viewModel.PassportNumber,
				PassportGivenByWhom = viewModel.PassportGivenByWhom,
				PassportGivenDate = viewModel.GetPassportGivenDate(),
				PassportImages = viewModel.PassportImages,
				INNImages = viewModel.INNImages,
                CreationDate = DateTime.Now
			};
			
			_context.Orders.Add(order);
			_context.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}