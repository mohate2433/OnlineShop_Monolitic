using Microsoft.AspNetCore.Mvc;
using OnlineShop_Mvp.Services.Contracts;
using OnlineShop_Mvp.Services.Dtos.ProductDtos;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.FillGrid());
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product_Save_Dto product)
        {
            if (ModelState.IsValid)
            {
                _productService.Save(product);
                RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Edit(Guid id)
        {
            var person = _productService.FindEdit(id);
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product_Edit_Dto product)
        {
            if (ModelState.IsValid)
            {
                _productService.Edit(product);
                RedirectToAction("index");
            }
            return View(product);
        }
        public IActionResult Delete(Guid id)
        {
            _productService.Delete(id);
            return RedirectToAction("index");
        }
        public IActionResult Details(Guid id)
        {
            var person = _productService.Find(id);
            return View(person);
        }
    }
}
