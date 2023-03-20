using Comparador.DataAccess.Data;
using Comparador.Models;
using Comparador.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Comparador.Web.Areas.Public.Controllers
{
    [Area("Public")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProdutosVM produtosVM = new()
            {
                Products = _context.Products
                    .Include(_ => _.Brand)
                    .Include(_ => _.Category)
                    .OrderBy(_ => _.Name)
                    .ToList()
            };

            List<Product> products = produtosVM.Products.ToList();

            return View(products);
        }
    }
}
