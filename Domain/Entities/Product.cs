using Domain.Entities.BaseCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product :BaseEntity
    {
        public Product()
        {

        }
        public Product(string name, int stock, decimal price, string description) : this()
        {
            Name = name;
            Stock = stock;
            Price = price;
            Description = description;
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}






























