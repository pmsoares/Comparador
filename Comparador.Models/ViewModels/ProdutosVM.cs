using Microsoft.AspNetCore.Mvc.Rendering;

namespace Comparador.Models.ViewModels
{
    public class ProdutosVM
    {
        public Product Product { get; set; } = null!;

        public IEnumerable<Product> Products { get; set; } = null!;

        public IEnumerable<SelectListItem> Categories { get; set; } = null!;

        public IEnumerable<SelectListItem> Brands { get; set; } = null!;
    }
}
