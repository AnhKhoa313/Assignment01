using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> products = new();
        private static readonly object lockObj = new();

        public static List<Product> GetProducts() => products;

        public static Product? GetProductById(int id) =>
            products.FirstOrDefault(p => p.ProductID == id);

        public static void AddProduct(Product product)
        {
            lock (lockObj)
            {
                products.Add(product);
            }
        }

        public static void UpdateProduct(Product product)
        {
            var existing = GetProductById(product.ProductID);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.CategoryID = product.CategoryID;
                existing.UnitPrice = product.UnitPrice;
                existing.UnitsInStock = product.UnitsInStock;
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
