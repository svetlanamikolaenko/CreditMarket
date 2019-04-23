using CreditMarket.Models;
using System.Collections.Generic;

namespace CreditMarket.ViewModels
{
    public class OrderFormViewModel: Base
	{
		public IEnumerable<Loan> Loan { get; set; }
		public Order Order { get; set; }
	}
}