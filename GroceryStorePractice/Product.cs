using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStorePractice
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int inventory { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{name} - {description}. ${price} Amount:{inventory} {category}";
        }
    }
}
