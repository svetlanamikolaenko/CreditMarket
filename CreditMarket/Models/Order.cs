using System;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Models
{
    public class Order: Base
	{
		
		public Loan Loan { get; set; }

		[Required(ErrorMessage = "Оберіть кредит")]
		public int LoanId { get; set; }

        [Required(ErrorMessage = "Вкажіть суму кредиту")]
        public double? Amount { get; set; }

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
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email обов'язкове до заповнення")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Необхідно заповнити номер телефону")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Вкажіть індивідуальний код платника податків")]
        public long? INN { get; set; }

        [Required(ErrorMessage = "Вкажіть серію та номер паспорту")]
        [StringLength(8)]
        public string PassportNumber { get; set; }

        [Required(ErrorMessage = "Поле ким виданий паспорт є обов'язкове")]
        [StringLength(120)]
        public string PassportGivenByWhom { get; set; }

        [Required(ErrorMessage = "Необхідно вказати дату видачі паспорту")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? PassportGivenDate { get; set; }

		public byte[] PassportImages { get; set; }

		public byte[] INNImages { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ApprovedDate { get; set; }

		public string OrderStatus { get; set; }

        [Required(ErrorMessage = "Необхідно вказати номер картки")]
        public long? CardNumber { get; set; }

        public bool IsSaved { get; set; } = false;

        public string FullName
		{
			get
			{
				return LastName + " " + FirstName + " " + FathersName;
			}
		}
	}
}