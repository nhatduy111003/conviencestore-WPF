using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDAO
    {
        private ASSPRN221Context assPRN221Context;
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }


        public CategoryDAO()
        {
            assPRN221Context = new ASSPRN221Context();
        }

        public bool AddCategory(Category category)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Categories.Add(category);
                assPRN221Context.SaveChanges();
                isSuccess = true;
            }
            finally
            {

            }
            return isSuccess;
        }

        public Category GetCategory(int categoryId)
        {
            try
            {
                var category = assPRN221Context.Categories.FirstOrDefault(x => x.Id == categoryId);

                return category;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> GetAllCategories() => assPRN221Context.Categories.ToList();

        public bool UpdateProduct(Category category)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Categories.Update(category);
                assPRN221Context.SaveChanges();
                isSuccess = true;
            }
            finally
            {

            }
            return isSuccess;
        }

        public bool DeleteCategory(int id)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Categories.Remove(GetCategory(id));
                assPRN221Context.SaveChanges();
                isSuccess = true;
            }
            finally
            {

            }
            return isSuccess;
        }
    }

}
