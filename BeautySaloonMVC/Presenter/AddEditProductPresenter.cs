using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.View;

namespace BeautySaloonMVC.Presenter
{
    public class AddEditProductPresenter
    {
        private readonly IAddEditProductView _view;
        private readonly IRepository _repository;

        public AddEditProductPresenter(IAddEditProductView view, IRepository repository, string t)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
            UpdateAddEditListView(t);
        }

        public void UpdateAddEditListView(string t)
        {
            Product product = _repository.GetProduct(t);
            _view.Title = product.Title;
            _view.Cost = product.Cost;
            _view.MainImagePath = product.MainImagePath;
            _view.IsActive = product.IsActive;
            _view.Manufactorer = product.ManufacturerName;
            _view.Description = product.Description;
        }

        public void SaveProduct(string t)
        {
            Product _product = new Product
            {
                Title = _view.Title,
                Cost = _view.Cost,
                MainImagePath = _view.MainImagePath,
                IsActive = _view.IsActive,
                ManufacturerName = _view.Manufactorer,
                Description = _view.Description
            };
            _repository.SaveProduct(t, _product);
            UpdateAddEditListView(t);
        }

        public void DeleteProduct()
        {
            Product _product = new Product
            {
                Title = _view.Title,
                Cost = _view.Cost,
                MainImagePath = _view.MainImagePath,
                IsActive = _view.IsActive,
                ManufacturerName = _view.Manufactorer,
                Description = _view.Description
            };
            _repository.DeleteProduct(_product);
        }
    }
}
