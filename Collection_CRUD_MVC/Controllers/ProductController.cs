using Microsoft.AspNetCore.Mvc;
using Collection_CRUD_MVC.Models;
using Collection_CRUD_MVC.Repositories;

namespace Collection_CRUD_MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository rep =new ProductRepository();
        public IActionResult Index()
        {
            List<Product> products = rep.GetAllProducts();
            return View(products);
        }

        public IActionResult Start()
        {
            return View();

        }

        

        public IActionResult Details(int productId)
        {
            Product product = rep.GetProduct(productId);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, double price, string category)
        {
            Product product = new Product();
            product.Name = name;
            product.ProductId = rep.GetAllProducts().Count() + 1;
            product.Price = price;
            rep.AddNewProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int productId)
        {
            Product product = rep.GetProduct(productId);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            rep.UpdateProductByPrice(product.ProductId, product.Price);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int productId)
        {
            Product product = rep.GetProduct(productId);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int ProductId)
        {
            rep.DeleteProduct(ProductId);
            return RedirectToAction("Index");
        }
    }
}
