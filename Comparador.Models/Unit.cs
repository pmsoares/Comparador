using System.ComponentModel.DataAnnotations;

namespace Comparador.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; } = null!;
    }
}
