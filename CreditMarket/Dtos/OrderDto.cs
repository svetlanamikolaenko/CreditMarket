using CreditMarket.Models;
using CreditMarket.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Dtos
{
    public class OrderDto: Base
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
        [DateValidation]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DateOfBirth { get; set; }

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
        [DateValidation]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
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