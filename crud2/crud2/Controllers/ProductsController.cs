using crud2.Models;
using crud2.VioModells;
using Microsoft.AspNetCore.Mvc;

namespace crud2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var _context = new _DbContext();
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            var _context = new _DbContext();
            var viewModle = new ProductViewModel()
            {
                categories = _context.categories.OrderBy(x => x.Name).ToList()
            };
            return View(viewModle);
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productView)
        {
            var _context = new _DbContext();
            productView.categories = _context.categories.ToList();
            _context.Products.Add(new Product
            {
                Name = productView.Name,
                price = productView.price,
                CategoryId = productView.CategoryId,
                Id = productView.Id,
            });
            _context.SaveChanges();
            return View(productView);
        }

        public IActionResult Edit(int? Id)
        {
            var _context = new _DbContext();
            if (Id == null) return BadRequest();
            var product = _context.Products.FirstOrDefault(x => x.Id == Id);
            if (product is null) return NotFound();
            var viewModle = new ProductViewModel()
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Name = product.Name,
                price = product.price,
                categories = _context.categories.OrderBy(x => x.Name).ToList()
            };
            return View("Edit", viewModle);
        }
    }
}