using Application.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concretes
{
    public class InProductManager : IProductService
    {
        public List<Product> GetProducts()

            => new() {
                new Product ("Product 1",15,100),
                new Product ("Product 2",11,100),
                new Product ("Product 3",18,100),
                new Product ("Product 4",12,100),
                new Product ("Product 5",14,100),
                new Product ("Product 6",9,100),
            };
        
    }
}
