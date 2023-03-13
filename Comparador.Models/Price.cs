using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Comparador.Models
{
    public class Price
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public DateTime ValueDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [ValidateNever]
        public Product Product { get; set; } = null!;

        [Required]
        [Display(Name = "Store")]
        public int StoreId { get; set; }

        [ValidateNever]
        public Store Store { get; set; } = null!;
    }
}
