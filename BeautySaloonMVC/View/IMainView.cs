using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;

namespace BeautySaloonMVC.View
{
    public interface IMainView
    {
        void ShowProducts(List<Product> products,int n);

        Presenter.MainPresenter Presenter { set; }
    }
}
