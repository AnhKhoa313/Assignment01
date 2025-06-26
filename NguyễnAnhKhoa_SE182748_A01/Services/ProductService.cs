using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo = ProductRepository.Instance;

        public List<Product> GetProducts() => repo.GetProducts();
        public Product? GetProductById(int id) => repo.GetProductById(id);
        public void AddProduct(Product product) => repo.AddProduct(product);
        public void UpdateProduct(Product product) => repo.UpdateProduct(product);
        public void DeleteProduct(int id) => repo.DeleteProduct(id);
    }
}
