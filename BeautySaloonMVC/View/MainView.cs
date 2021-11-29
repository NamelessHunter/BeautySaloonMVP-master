using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySaloonMVC.Model;
using BeautySaloonMVC.Presenter;
using BeautySaloonMVC.View;

namespace BeautySaloonMVC
{
    public partial class MainView : Form, IMainView
    {
        private ProductView _view;
        private Repository _repository;
        private ProductPresenter _presenter;
        private List<Product> _list;
        private List<Product> _Origlist;
        private int cn;
        private int count;

        public MainView()
        {
            InitializeComponent();
            AddManufactorerDB();
           // ManuFilter.SelectedIndex = 0;
        }
        public void ShowProducts(List<Product> list,int n)
        {
            _Origlist = list;
            _list = _Origlist;
            this.MainLayoutPanel.Controls.Clear();
            if (_list.Count % 6 == 0)
            {
                count = _list.Count / 6;
            }
            else
            {
                count = (_list.Count / 6) + 1;
            }
            for (int i = (n - 1)*6; i < _list.Count && i < n *6; i++)
            {
                this._view = new View.ProductView();
                this._repository = new Model.Repository();
                this._presenter = new Presenter.ProductPresenter(_view, _repository,_list[i].Title);
                this.MainLayoutPanel.Controls.Add(_view);
                this.cn = n;
            }
            BottomLayoutPanel.Controls.Clear();
            setCount(_Origlist.Count, _list.Count);
            ShowPagination();
            ManuFilter.SelectedIndex = 0;
        }
        private void ShowProductPage(int n)
        {
            this.MainLayoutPanel.Controls.Clear();
            if (_list.Count % 6 == 0)
            {
                count = _list.Count / 6;
            }
            else
            {
                count = (_list.Count / 6) + 1;
            }
            for (int i = (n - 1) * 6; i < _list.Count && i < n * 6; i++)
            {
                    this._view = new View.ProductView();
                    this._repository = new Model.Repository();
                    this._presenter = new Presenter.ProductPresenter(_view, _repository, _list[i].Title);
                    this.MainLayoutPanel.Controls.Add(_view);
                    this.cn = n;
            }
            BottomLayoutPanel.Controls.Clear();
            ShowPagination();
            setCount(_Origlist.Count, _list.Count);
        }
        ///////////////////////////////////////начало пагинации////////////////////////////////////////////////////////////
        private void ShowPagination()
        {
            int n = count;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0) this.AddLeftRight("<");
                else
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = i.ToString();
                    linkLabel.Size = new Size(30, 60);
                    linkLabel.AutoSize=true;
                    linkLabel.LinkClicked += ShowPage;
                    BottomLayoutPanel.Controls.Add(linkLabel);
                }
            }
            this.AddLeftRight(">");
        }
        private void ShowPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int n = int.Parse((sender as LinkLabel).Text);
            this.MainLayoutPanel.Controls.Clear();
            ShowProductPage(n);
        }
        private void AddLeftRight(string text)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = text;
            linkLabel.Size = new Size(10, 50);
            if (text.Equals("<"))
                linkLabel.LinkClicked += this.ShowLeftProduct;
            else
                linkLabel.LinkClicked += this.ShowRightProduct;
            this.BottomLayoutPanel.Controls.Add(linkLabel);
        }
        private void ShowLeftProduct(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(cn>1)
            {
                int n = this.cn;
                n--;
                this.MainLayoutPanel.Controls.Clear();
                ShowProductPage(n);
            }
        }
        private void ShowRightProduct(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_list.Count % 6 == 0)
            {
                if (cn <_list.Count / 6)
                {
                    int n = this.cn;
                    n++;
                    this.MainLayoutPanel.Controls.Clear();
                    ShowProductPage(n);
                }
            }
            else 
            {
                if (cn < (_list.Count / 6)+1)
                {
                    int n = this.cn;
                    n++;
                    this.MainLayoutPanel.Controls.Clear();
                    ShowProductPage(n);
                }
            }
        }
        ////////////////////////////////////////конец пагинации///////////////////////////////////////


        ////////////////////////////////////////начало фильтрации/////////////////////////////////////
        private void filterByName(string text)
        {
            //_list = _Origlist;
            _list = _list.Where(u => u.Title.StartsWith(text)).ToList();
        }
        public void filterBy(string text)
        {
            _list = _Origlist;
            _list = _list.Where(u => u.ManufacturerName.StartsWith(text)).ToList();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                if (ManuFilter.SelectedIndex == 0)
                {
                    _list = _Origlist;
                }
                else
                    filterBy(ManuFilter.SelectedItem.ToString());
                ShowProductPage(1);
            }
            else
            {
                filterByName(textBoxSearch.Text);
                ShowProductPage(1);
            }    
        }
        private void ManuFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManuFilter.SelectedIndex == 0)
            {
                _list = _Origlist;
                ShowProductPage(1);
            }
            else
            {
                filterBy(ManuFilter.SelectedItem.ToString());
                ShowProductPage(1);
            }
        }
        private void radioSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            SortByCost();
        }

        private void radioSortDesc_CheckedChanged(object sender, EventArgs e)
        {
            SortByCostDesc();
        }
        public void addManufactorer(string[] Manufacturer)
        {
            foreach (string item in Manufacturer)
            {
                ManuFilter.Items.Add(item);
            }
        }
        public void SortByCost()
        {
            _list = _list.OrderBy(u => u.Cost).ToList();
            ShowProductPage(1);
        }
        public void SortByCostDesc()
        {
            _list = _list.OrderByDescending(u => u.Cost).ToList();
            ShowProductPage(1);
        }

        ////////////////////////////////////////конец фильтрации//////////////////////////////////////

     
        public void setCount(int all, int otbor)
        {
            this.toolStripStatusLabel1.Text = otbor + " из " + all;
        }

        public void AddManufactorerDB()
        {
            using (Model1 db = new Model1())
            {
                string[] manufactorer = db.Manufacturer.Select(p => p.Name).ToArray();
                this.addManufactorer(manufactorer);
            }
        }
        public MainPresenter Presenter { private get; set; }

        //Мусор
        private void BottomLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}