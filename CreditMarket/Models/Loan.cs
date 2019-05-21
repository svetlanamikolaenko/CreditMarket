using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Models
{
    public class Loan: Base
	{
        [Required(ErrorMessage = "Вкажіть назву кредиту")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вкажіть термін кредиту")]
        public int? Period { get; set; }

        [Required(ErrorMessage = "Вкажіть відсоткову ставку кредиту")]
        [Range(0.01, 99.99)]
        public double? Procent { get; set; }
    }
}