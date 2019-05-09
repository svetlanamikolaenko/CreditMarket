using CreditMarket.Models;
using CreditMarket.ViewModels;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
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

        [HttpGet]
        public ActionResult Details(int id)
        {

            var order = _context.Orders.SingleOrDefault(o => o.Id == id);

            if (order == null)
                return HttpNotFound();

            var viewModel = new OrderFormViewModel
            {
                Order = order,
                Loan = _context.Loans.ToList()
            };

            return View("Details", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(Order order, HttpPostedFileBase uploadPassportImage, HttpPostedFileBase uploadINNImage)
        {
            byte[] imagePassport = null;
            if (uploadPassportImage != null)
            {
                using (var binaryReader = new BinaryReader(uploadPassportImage.InputStream))
                {
                    imagePassport = binaryReader.ReadBytes(uploadPassportImage.ContentLength);
                }
                order.PassportImages = imagePassport;
            }

            byte[] imageINN = null;
            if (uploadINNImage != null)
            {
                using (var binaryReader = new BinaryReader(uploadINNImage.InputStream))
                {
                    imageINN = binaryReader.ReadBytes(uploadINNImage.ContentLength);
                }
                order.INNImages = imageINN;
            }

            var orderInDb = _context.Orders.Single(o => o.Id == order.Id);

            if (Request.Form["approve"] != null)
            {
                order.OrderStatus = "Підтверджено";
                order.ApprovedDate = DateTime.Now.Date;
            }
            else if (Request.Form["decline"] != null)
            {
                order.OrderStatus = "Відмовлено";
                order.ApprovedDate = DateTime.Now.Date;
            }

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
            orderInDb.CardNumber = order.CardNumber;
            orderInDb.OrderStatus = order.OrderStatus;
            orderInDb.ApprovedDate = order.ApprovedDate;

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
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
        public ActionResult Create(Order order, HttpPostedFileBase uploadPassportImage, HttpPostedFileBase uploadINNImage)
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
            byte[] imagePassport = null;
            byte[] imageINN = null;

            if (order.Id == 0)
            {

                if (uploadPassportImage != null)
                {
                    using (var binaryReader = new BinaryReader(uploadPassportImage.InputStream))
                    {
                        imagePassport = binaryReader.ReadBytes(uploadPassportImage.ContentLength);
                    }
                    order.PassportImages = imagePassport;
                }

                if (uploadINNImage != null)
                {
                    using (var binaryReader = new BinaryReader(uploadINNImage.InputStream))
                    {
                        imageINN = binaryReader.ReadBytes(uploadINNImage.ContentLength);
                    }

                    order.INNImages = imageINN;
                }



                _context.Orders.Add(order);
            }

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
                orderInDb.CardNumber = order.CardNumber;

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
        public ActionResult Edit(Order order, HttpPostedFileBase uploadPassportImage, HttpPostedFileBase uploadINNImage)
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
            byte[] imagePassport = null;
            if (uploadPassportImage != null)
            {
                using (var binaryReader = new BinaryReader(uploadPassportImage.InputStream))
                {
                    imagePassport = binaryReader.ReadBytes(uploadPassportImage.ContentLength);
                }
                order.PassportImages = imagePassport;
            }

            byte[] imageINN = null;
            if (uploadINNImage != null)
            {
                using (var binaryReader = new BinaryReader(uploadINNImage.InputStream))
                {
                    imageINN = binaryReader.ReadBytes(uploadINNImage.ContentLength);
                }
                order.INNImages = imageINN;
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
                orderInDb.CardNumber = order.CardNumber;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Orders");
        }
    }
}