using ProductCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.ViewModel
{
    public class ProductModel
    {
        private Product prod;
        //sucess ghh


        public List<Product> _products { get; set; }
        public List<Product> findAll()
        {
            _products = new List<Product>
            {
                new Product()
                {
                    Id ="1",
                    Name="SAMSUNG",
                    price =200

                },
                new Product()
                {
                    Id ="2",
                    Name="nokia",
                    price =250

                }
            };
            return _products;
        }
        public Product find(string id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        }
    }
}

