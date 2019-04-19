using CreditMarket.Models;
using CreditMarket.ViewModels;
using System.Linq;
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

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		public ViewResult Index()
		{
			var loans = _context.Loans;

			return View(loans);
		}


		//[Authorize]
		public ActionResult Create()
		{
			return View();
		}

		//[Authorize]
		[HttpPost]
		//[ValidateAntiForgeryToken]
		public ActionResult Create(Loan loan)
		{
            if (!ModelState.IsValid)
            {
                var viewModel = new LoanFormViewModel()
                {
                    Loan = loan,
                };

                return View("Create", viewModel);
            }

            if (loan.Id == 0)
                _context.Loans.Add(loan);
            else
            {
                var loanInDb = _context.Loans.Single(l => l.Id == loan.Id);

                loanInDb.Name = loan.Name;
                loanInDb.Period = loan.Period;
                loanInDb.Procent = loan.Procent;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Loans");
        }

        public ActionResult Edit(int id)
        {
            var loan = _context.Loans.SingleOrDefault(l => l.Id == id);

            if (loan == null)
                return HttpNotFound();

            var viewModel = new LoanFormViewModel()
            {
                Loan = loan,
            };

            return View("Create", viewModel);
        }
    }
}