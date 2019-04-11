using CreditMarket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CreditMarket.ViewModels
{
	public class OrderFormViewModel: Base
	{
		public IEnumerable<Loan> Loan { get; set; }
		public int LoanId;
		public Order Order { get; set; }

		[Required(ErrorMessage = "Вкажіть суму кредиту")]
		public double Amount { get; set; }

		[Required(ErrorMessage = "Ім'я обов'язкове до заповнення")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Прізвище обов'язкове до заповнення")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required(ErrorMessage = "По-батькові обов'язкове до заповнення")]
		[StringLength(50)]
		public string FathersName { get; set; }

		[Required(ErrorMessage = "Дата народження обов'язкова до заповнення")]
		[DateValidation]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
		public string DateOfBirth { get; set; }

		[Required(ErrorMessage = "Email обов'язкове до заповнення")]
		[StringLength(50)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Необхідно заповнити номер телефону")]
		[StringLength(12)]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Вкажіть індивідуальний код платника податків") ]
		public long INN { get; set; }

		[Required(ErrorMessage = "Вкажіть серію та номер паспорту")]
		[StringLength(8)]
		public string PassportNumber { get; set; }

		[Required(ErrorMessage = "Поле ким виданий паспорт є обов'язкове")]
		[StringLength(120)]
		public string PassportGivenByWhom { get; set; }

		[Required(ErrorMessage = "Необхідно вказати дату видачі паспорту")]
		[DateValidation]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
		public string PassportGivenDate { get; set; }

		public byte[] PassportImages { get; set; }

		public byte[] INNImages { get; set; }

		public DateTime? GetDateOfBirth()
		{
			return DateTime.ParseExact(DateOfBirth, "dd-MM-yyyy", CultureInfo.CurrentCulture);
		}

		public DateTime? GetPassportGivenDate()
		{
			return DateTime.ParseExact(PassportGivenDate, "dd-MM-yyyy", CultureInfo.CurrentCulture);
		}


		public string FullName
		{
			get
			{
				return LastName + " " + FirstName + " " + FathersName;
			}
		}
	}
}