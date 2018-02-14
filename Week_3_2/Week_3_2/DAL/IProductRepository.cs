using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_2.Models;

namespace Week_3_2.DAL
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductByID(int id);
    }
}
