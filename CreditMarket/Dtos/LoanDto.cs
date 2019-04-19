using CreditMarket.Models;
using System.ComponentModel.DataAnnotations;

namespace CreditMarket.Dtos
{
    public class LoanDto: Base
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int? Period { get; set; }

        [Required]
        [Range(1, 100)]
        public int? Procent { get; set; }
    }
}