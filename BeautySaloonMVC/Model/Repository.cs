using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            using (Model1 db=new Model1())
            {
                db.Product.Add(product);
                db.SaveChanges();
                _products = new Lazy<List<Product>>(
               () =>
               {
                   return db.Product.ToList();
               });
            }
        }

        public void DeleteProduct(Product product)
        {
            using (Model1 db = new Model1())
            {
                Product p = db.Product.Where(i => i.Title.Equals(product.Title)).FirstOrDefault();
                db.Entry(p).State = EntityState.Deleted;
                db.SaveChanges();
                _products = new Lazy<List<Product>>(
                   () =>
                   {
                       return db.Product.ToList();
                   });
            }
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
            using (Model1 db = new Model1())
            {
                Product p = db.Product.Where(i=>i.Title.Equals(title)).FirstOrDefault();
                p.Cost = product.Cost;
                p.Description = product.Description;
                p.IsActive = product.IsActive;
                p.MainImagePath = product.MainImagePath;
                p.ManufacturerName = product.ManufacturerName;
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
                _products = new Lazy<List<Product>>(
                   () =>
                   {
                       return db.Product.ToList();
                   });
            }
        }
    }
}
