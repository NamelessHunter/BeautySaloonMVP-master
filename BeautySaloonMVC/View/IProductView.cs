using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonMVC.View
{
    public interface IProductView
    {
        string Title { get; set; }
        double Cost { get; set; }
        string MainImagePath { get; set; }
        string IsActive { get; set; }
        string Manufactorer { get; set; }

        Presenter.ProductPresenter Presenter { set; }
    }
}
