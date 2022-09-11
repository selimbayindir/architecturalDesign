using Application.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concretes
{
    internal class ProductManager : IProductService
    {
        public List<Product> GetProducts()

            => new() {
                new Product ("Product 1",10,100,"Product"),
                new Product ("Product 2",10,100,"Product"),
                new Product ("Product 3",10,100,"Product"),
                new Product ("Product 4",10,100,"Product"),
                new Product ("Product 5",10,100,"Product"),
                new Product ("Product 6",10,100,"Product"),
            };
        
    }
}
