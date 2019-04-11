using System;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Models
{
    public class Order: Base
	{
		
		public Loan Loan { get; set; }

		[Required(ErrorMessage = "Оберіть кредит")]
		public int LoanId { get; set; }

        public double Amount { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string FathersName { get; set; }

		public DateTime? DateOfBirth { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public long INN { get; set; }

		public string PassportNumber { get; set; }

		public string PassportGivenByWhom { get; set; }

		public DateTime? PassportGivenDate { get; set; }

		public byte[] PassportImages { get; set; }

		public byte[] INNImages { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime ApprovedDate { get; set; }

		public string OrderStatus { get; set; }

		public string FullName
		{
			get
			{
				return LastName + " " + FirstName + " " + FathersName;
			}
		}
	}
}