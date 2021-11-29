using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.View;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;


namespace BeautySaloonMVC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repository = new Model.Repository();
            var view = new MainView();
            var presenter = new Presenter.MainPresenter(view, repository);
            Application.Run(view);
        }
    }
}
