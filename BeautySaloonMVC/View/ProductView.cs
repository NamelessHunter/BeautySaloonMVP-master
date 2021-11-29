using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;

namespace BeautySaloonMVC.View
{
    public partial class ProductView : UserControl,IProductView
    {
        public ProductView()
        {
            InitializeComponent();

            this.pictureBox1.MouseDoubleClick += openForEdit;
            this.labelProductName.MouseDoubleClick += openForEdit;
            this.labelCost.MouseDoubleClick += openForEdit;
            this.labelActive.MouseDoubleClick += openForEdit;
        }

        public string Title { 
            get { return labelProductName.Text; }
            set { labelProductName.Text = value; }
        }
        public double Cost {  
            get { return double.Parse(labelCost.Text); } 
            set { labelCost.Text = value.ToString() + " рублей"; }
        }
        public string IsActive { 
            get { return labelActive.Text; } 
            set { labelActive.Text = value; } 
        }
        public string MainImagePath { 
            get { return pictureBox1.ImageLocation; }
            set {
                if (value != null)
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + value.Trim());
                else
                    pictureBox1.Image = Properties.Resources.picture;
            }
        }
        public string Manufactorer { get;set; }
        private void ProductView_Load(object sender, EventArgs e)
        {
            if (labelActive.Text == " да")
                labelActive.Visible =false;
            if (labelActive.Text == " нет")
            {
                labelActive.Text = "Не активен";
                this.BackColor = Color.LightGray;
            }
        }

        private void openForEdit(object sender, MouseEventArgs e)
        {
            AddEditProductView _addEditView = new AddEditProductView();
            Repository _repository = new Repository();
            AddEditProductPresenter _addEditProductPresenter = new AddEditProductPresenter(_addEditView,_repository,this.Title);
            _addEditView.ShowDialog();
        }









        public ProductPresenter Presenter
        {
            private get;
            set;
        }

        private void labelCost_Click(object sender, EventArgs e)
        {

        }
    }
}
