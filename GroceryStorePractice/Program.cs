using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;
using GroceryStorePractice;

var db = new MySqlConnection("server=127.0.0.1;database=grocerystore;Uid=root;pwd=abc123;");

List<Product> items = db.GetAll<Product>().ToList();

foreach (var item in items)
{
    Console.WriteLine(item);
}

//Product newitem = new Product() { name="Ring Pop",description="Sucker that looks like ring",price=0.50,inventory=100,category="MEAT" };
//db.Insert(newitem);
//db.Delete(new Product() { id =13});

//Product FrenchFries = db.Get<Product>(11);
//FrenchFries.description = "FROZEN THESE ARE FROZEN YOU MUST FRY THEM";
//db.Update<Product>(FrenchFries);