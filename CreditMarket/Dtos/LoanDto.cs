using CreditMarket.Models;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Dtos
{
    public class LoanDto: Base
    {
        [Required(ErrorMessage = "Вкажіть назву кредиту")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вкажіть термін кредиту")]
        public int? Period { get; set; }

        [Required(ErrorMessage = "Вкажіть відсоткову ставку кредиту")]
        [Range(1, 100)]
        public int? Procent { get; set; }
    }
}