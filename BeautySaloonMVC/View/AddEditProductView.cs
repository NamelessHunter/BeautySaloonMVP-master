using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;

namespace BeautySaloonMVC.View
{
    public partial class AddEditProductView : Form,IAddEditProductView
    {
        private string pathToImage;

        public AddEditProductView()
        {
            InitializeComponent();
            AddManufactorerDB();
        }

        public string Title { 
            get { return textBoxTitle.Text; }
            set { textBoxTitle.Text = value; } }
        public double Cost { 
            get { return double.Parse(textBoxCost.Text); }
            set { textBoxCost.Text = value.ToString(); }
        }
        public string MainImagePath { 
            get { return pathToImage; }
            set
            {
                if (value != null)
                    pictureBoxImage.Image = Image.FromFile(Application.StartupPath + "\\" + value.Trim()); 
                else
                    pictureBoxImage.Image = Properties.Resources.picture;
            }
            }
        public string IsActive  { 
            get
            {
                if (radioActiveYes.Checked)
                    return " да";
                else
                    return " нет";
            }
            set 
            {
                if (value.ToString() == " да")
                    radioActiveYes.Checked = true;
                else
                    radioActiveNo.Checked =true;
            } }
        public string Manufactorer
        {
            get
            { return comboBoxManufactorer.Text; }
            set
            {
                comboBoxManufactorer.Text = value;
            }
        }
        public string Description{
            get { return TextBoxDescription.Text; }
            set { TextBoxDescription.Text = value; }
        }

        public void AddManufactorerDB()
        {
            using (Model1 db = new Model1())
            {
                string[] manufactorer = db.Manufacturer.Select(p => p.Name).ToArray();
                foreach (string item in manufactorer)
                {
                    comboBoxManufactorer.Items.Add(item);
                }
            }
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            Presenter.SaveProduct(this.Title);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Presenter.DeleteProduct();
        }
        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBoxImage.Image = Image.FromFile(openFileDialog1.FileName);
            pathToImage = @"\materials\" + openFileDialog1.SafeFileName;

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(Environment.CurrentDirectory + pathToImage, true);
            }
        }

        public AddEditProductPresenter Presenter
        {
            private get;
            set;
        }
    }
}
