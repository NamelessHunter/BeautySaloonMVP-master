using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonMVC.Model
{
    public interface IRepository
    {
        IEnumerable<Product> getAllProduct();
        Product GetProduct(string title);
        void SaveProduct(string title, Product product);
        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
