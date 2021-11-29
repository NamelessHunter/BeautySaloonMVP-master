using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.View;

namespace BeautySaloonMVC.Presenter
{
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly IRepository _repository;

        public ProductPresenter(IProductView view, IRepository repository,string t)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
            UpdateProductListView(t);
        }
        public void UpdateProductListView(string t)
        {
            Product product = _repository.GetProduct(t);
            _view.Title = product.Title;
            _view.Cost = product.Cost;
            _view.MainImagePath = product.MainImagePath;
            _view.IsActive = product.IsActive;
            _view.Manufactorer = product.ManufacturerName;
        }
    }
}
