using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonMVC.Model
{
    public class Repository : IRepository
    {
        private Lazy<List<Product>> _products;
        private List<Product> _list;

        public Repository()
        {
            _products = new Lazy<List<Product>>(
                ()=>
                {
                    using (Model1 db = new Model1())
                    {
                        return db.Product.ToList();
                    }
                });

            using (Model1 db = new Model1())
            {
                _list = db.Product.ToList();
            }
        }

        public void AddProduct(Product product)
        {
            
        }

        public void DeleteProduct(Product product)
        {
            
        }

        public IEnumerable<Product> getAllProduct()
        {
            return _products.Value;
        }

        public Product GetProduct(string title)
        {
            return _products.Value.Where(p=>p.Title.Equals(title)).FirstOrDefault();
        }

        public void SaveProduct(string title, Product product)
        {
            


        }
    }
}
