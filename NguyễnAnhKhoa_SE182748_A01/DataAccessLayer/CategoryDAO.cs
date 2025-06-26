using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        private static List<Category> categories = new();
        private static readonly object lockObj = new();

        public static List<Category> GetCategories() => categories;

        public static Category? GetCategoryById(int id) =>
            categories.FirstOrDefault(c => c.CategoryID == id);

        public static void AddCategory(Category category)
        {
            lock (lockObj)
            {
                categories.Add(category);
            }
        }

        public static void UpdateCategory(Category category)
        {
            var existing = GetCategoryById(category.CategoryID);
            if (existing != null)
            {
                existing.CategoryName = category.CategoryName;
                existing.Description = category.Description;
            }
        }

        public static void DeleteCategory(int id)
        {
            var cat = GetCategoryById(id);
            if (cat != null)
            {
                categories.Remove(cat);
            }
        }
    }
}
