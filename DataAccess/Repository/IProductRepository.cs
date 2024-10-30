using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public bool AddProduct(Product product);
        public Product GetProduct(int id);

        public List<ProductDTO> GetProducts();

        public bool UpdateProduct(Product product);

        public bool DeleteProduct(int id);
    }
}
