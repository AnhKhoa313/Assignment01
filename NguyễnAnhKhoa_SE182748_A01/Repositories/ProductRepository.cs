using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static readonly ProductRepository instance = new();
        public static ProductRepository Instance => instance;

        private ProductRepository() { }

        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public Product? GetProductById(int id) => ProductDAO.GetProductById(id);
        public void AddProduct(Product product) => ProductDAO.AddProduct(product);
        public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);
        public void DeleteProduct(int id) => ProductDAO.DeleteProduct(id);
    }
}