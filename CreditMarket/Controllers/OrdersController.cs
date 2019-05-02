using CreditMarket.Models;
using CreditMarket.ViewModels;
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

        public ActionResult Details(int id)
        {
            var order = _context.Orders.SingleOrDefault(o => o.Id == id);

            if (order == null)
                return HttpNotFound();

            return View(order);
        }

        //[Authorize]
        public ActionResult Create()
		{
			var viewModel = new OrderFormViewModel
			{
                Order = new Order(),
                Loan = _context.Loans.ToList()
			};
			return View("Create", viewModel);
		}

		//[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new OrderFormViewModel()
                {
                    Order = order,
                    Loan = _context.Loans.ToList()
                };

                return View("Create", viewModel);
            }

            if (order.Id == 0)
                _context.Orders.Add(order);
            else
            {
                var orderInDb = _context.Orders.Single(o => o.Id == order.Id);

                orderInDb.Amount = order.Amount;
                orderInDb.LoanId = order.LoanId;
                orderInDb.LastName = order.LastName;
                orderInDb.FirstName = order.FirstName;
                orderInDb.FathersName = order.FathersName;
                orderInDb.DateOfBirth = order.DateOfBirth;
                orderInDb.Email = order.Email;
                orderInDb.PhoneNumber = order.PhoneNumber;
                orderInDb.INN = order.INN;
                orderInDb.PassportNumber = order.PassportNumber;
                orderInDb.PassportGivenByWhom = order.PassportGivenByWhom;
                orderInDb.PassportGivenDate = order.PassportGivenDate;
                orderInDb.PassportImages = order.PassportImages;
                orderInDb.INNImages = order.INNImages;
                orderInDb.CreationDate = order.CreationDate;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var order = _context.Orders.SingleOrDefault(o => o.Id == id);

            if (order == null)
                return HttpNotFound();

            var viewModel = new OrderFormViewModel
            {
                Order = order,
                Loan = _context.Loans.ToList()
            };

            return View("Edit", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order order)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new OrderFormViewModel()
                {
                    Order = order,
                    Loan = _context.Loans.ToList()
                };

                return View("Edit", viewModel);
            }

            if (order.Id == 0)
                _context.Orders.Add(order);
            else
            {
                var orderInDb = _context.Orders.Single(o => o.Id == order.Id);

                orderInDb.Amount = order.Amount;
                orderInDb.LoanId = order.LoanId;
                orderInDb.LastName = order.LastName;
                orderInDb.FirstName = order.FirstName;
                orderInDb.FathersName = order.FathersName;
                orderInDb.DateOfBirth = order.DateOfBirth;
                orderInDb.Email = order.Email;
                orderInDb.PhoneNumber = order.PhoneNumber;
                orderInDb.INN = order.INN;
                orderInDb.PassportNumber = order.PassportNumber;
                orderInDb.PassportGivenByWhom = order.PassportGivenByWhom;
                orderInDb.PassportGivenDate = order.PassportGivenDate;
                orderInDb.PassportImages = order.PassportImages;
                orderInDb.INNImages = order.INNImages;
                orderInDb.CreationDate = order.CreationDate;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }
    }
}