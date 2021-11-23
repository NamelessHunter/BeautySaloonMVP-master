using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Controller;
using BeautySaloonMVC.Model;

namespace BeautySaloonMVC.View
{
    public partial class ProductView : UserControl
    {
       
        public ProductView(Product _product)
        {
            InitializeComponent();
         
        }
      
    }
}
