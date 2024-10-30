using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public bool DeleteProduct(int id) => ProductDAO.Instance.DeleteProduct(id);

        public Product GetProduct(int id) => ProductDAO.Instance.GetProduct(id);

        public List<ProductDTO> GetProducts() => ProductDAO.Instance.GetAllProducts();

        public bool UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
