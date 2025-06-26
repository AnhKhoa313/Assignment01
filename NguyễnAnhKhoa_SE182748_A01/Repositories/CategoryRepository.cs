using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private static readonly CategoryRepository instance = new();
        public static CategoryRepository Instance => instance;

        private CategoryRepository() { }

        public List<Category> GetCategories() => CategoryDAO.GetCategories();
        public Category? GetCategoryById(int id) => CategoryDAO.GetCategoryById(id);
        public void AddCategory(Category category) => CategoryDAO.AddCategory(category);
        public void UpdateCategory(Category category) => CategoryDAO.UpdateCategory(category);
        public void DeleteCategory(int id) => CategoryDAO.DeleteCategory(id);
    }

}
