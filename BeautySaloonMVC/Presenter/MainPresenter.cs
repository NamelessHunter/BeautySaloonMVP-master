using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.View;

namespace BeautySaloonMVC.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IRepository _repository;

        public MainPresenter(IMainView view, IRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
            UptadeProductsView();
        }
        void UptadeProductsView()
        {
            using (Model1 db = new Model1())
            {
                List<Product> list = db.Product.ToList();
                _view.ShowProducts(list,1);
            }
                
        }
    }
}
