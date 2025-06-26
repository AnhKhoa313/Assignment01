using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repo = CategoryRepository.Instance;

        public List<Category> GetCategories() => repo.GetCategories();
        public Category? GetCategoryById(int id) => repo.GetCategoryById(id);
        public void AddCategory(Category category) => repo.AddCategory(category);
        public void UpdateCategory(Category category) => repo.UpdateCategory(category);
        public void DeleteCategory(int id) => repo.DeleteCategory(id);
    }
}
