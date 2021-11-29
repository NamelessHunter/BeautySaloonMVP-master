using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;

namespace BeautySaloonMVC.View
{
    public interface IAddEditProductView
    {
        string Title { get; set; }
        double Cost { get; set; }
        string MainImagePath { get; set; }
        string IsActive { get; set; }
        string Manufactorer { get; set; }
        string Description { get; set; }

        Presenter.AddEditProductPresenter Presenter { set; }
    }
}
