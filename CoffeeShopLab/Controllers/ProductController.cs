using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using CoffeeShopLab.Models;


namespace CoffeeShopLab.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("server=127.0.0.1;database=coffeeshop;Uid=root;pwd=abc123;");
            List<Product> prods = db.GetAll<Product>().ToList();

            return View(prods);
        }

        public IActionResult Detail(int id)
        {
            var db = new MySqlConnection("server=127.0.0.1;database=coffeeshop;Uid=root;pwd=abc123;");
            Product prod = db.Get<Product>(id);

            return View(prod);
        }
    }
}
