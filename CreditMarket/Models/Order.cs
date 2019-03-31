using System;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Models
{
	public class Order: Base
	{
		[Required]
		public Loan Loan { get; set; }

		[Required]
		public double Amount { get; set; }

		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[StringLength(50)]
		public string FathersName { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime DateOfBirth { get; set; }

		[StringLength(50)]
		public string Email { get; set; }

		[Required]
		[StringLength(12)]
		public string PhoneNumber { get; set; }

		[Required]
		public long INN { get; set; }

		[Required]
		[StringLength(8)]
		public string PassportNumber { get; set; }

		[Required]
		[StringLength(120)]
		public string PassportGivenByWhom { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime PassportGivenDate { get; set; }

		[Required]
		public byte[] PassportImages { get; set; }

		[Required]
		public byte[] INNImages { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime CreationDate { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime ApprovedDate { get; set; }

		public string OrderStatus { get; set; }
	}
}