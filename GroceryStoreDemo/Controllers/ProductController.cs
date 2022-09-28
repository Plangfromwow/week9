using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using GroceryStoreDemo.Models;

namespace GroceryStoreDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("server=127.0.0.1;database=grocerystore;Uid=root;pwd=abc123;");
            List<Product> prods = db.GetAll<Product>().ToList();

            return View(prods);
        }

    }
}
