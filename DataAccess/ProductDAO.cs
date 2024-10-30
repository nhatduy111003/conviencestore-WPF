using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {

        private ASSPRN221Context assPRN221Context;
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }

        public ProductDAO()
        {
            assPRN221Context = new ASSPRN221Context();
        }

        public bool AddProduct(Product product)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Products.Add(product);
                assPRN221Context.SaveChanges();
                isSuccess = true;
            }
            finally
            {

            }
            return isSuccess;
        }

        public Product GetProduct(int productId)
        {
            try
            {
                var product = assPRN221Context.Products.FirstOrDefault(x => x.Id == productId);

                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            var products = from p in assPRN221Context.Products
                           join c in assPRN221Context.Categories on p.CategoryId equals c.Id
                           select new ProductDTO
                           {
                               ProductId = p.Id,
                               ProductName = p.Name,
                               Price = p.Price,
                               Description = p.Description,
                               CategoryName = c.Name,
                               CreatedAt = c.CreatedAt 
                           };

            return products.ToList();
        }

        public bool UpdateProduct(Product product)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Products.Update(product);
                assPRN221Context.SaveChanges();
                isSuccess = true;
            }
            finally
            {

            }
            return isSuccess;
        }

        public bool DeleteProduct(int id)
        {
            bool isSuccess = false;
            try
            {
                assPRN221Context.Products.Remove(GetProduct(id));
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
