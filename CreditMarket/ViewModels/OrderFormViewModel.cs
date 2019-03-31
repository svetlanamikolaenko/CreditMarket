using CreditMarket.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.ViewModels
{
	public class OrderFormViewModel
	{
		[Required]
		public double Amount { get; set; }

		[Required]
		public int Loan { get; set; }

		public IEnumerable<Loan> Loans { get; set; }
	}
}