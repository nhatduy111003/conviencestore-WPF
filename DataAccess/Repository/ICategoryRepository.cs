using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        public bool AddCategory(Category category);


        public Category GetCategory(int id);

        public List<Category> GetAllCategories();

        public bool UpdateProduct(Category category);

        public bool DeleteCategory(int id);
    }
}