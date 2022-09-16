using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public string Description { get; set; }

        public Product(int id, string name, decimal price, string description = "")
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
