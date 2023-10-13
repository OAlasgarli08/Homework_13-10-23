using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService
    {
        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product{ Id = 1, Name = "Product 1", Price = 150, Colour = "red", Count = 10},
                new Product{ Id = 2, Name = "Product 2", Price = 350, Colour = "white", Count = 11},
                new Product{ Id = 3, Name = "Product 3", Price = 250, Colour = "black", Count = 1}
            };
        }

        public Product GetAllByCount(int count)
        {
            Product[] products = GetAll();

            return products.Where(m => m.Count > count).ToArray();
        }
    }
}
