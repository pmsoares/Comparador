using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Comparador.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(500)]
        public string? Description { get; set; }

        [ValidateNever]
        public byte? Image { get; set; } = 0;

        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Unit")]
        public int UnitId { get; set; }

        [ValidateNever]
        public Unit Unit { get; set; } = null!;

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [ValidateNever]
        public Brand Brand { get; set; } = null!;
    }
}
