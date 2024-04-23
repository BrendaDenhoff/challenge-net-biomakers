using EntityLayer.Models;
using PresentationLayer.Presenters;
using PresentationLayer.Views.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class OrderArticleCreateView : Form, IOrderArticleCreateView
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string NumberOfArticle
        {
            get { return txtNumberOfArticle.Text; }
            set { txtNumberOfArticle.Text = value; }
        }
        public string Article
        {
            get { return cmbArticles.SelectedItem.ToString(); }
            set { cmbArticles.SelectedItem = value; }
        }

        public bool IsEditMode { get; set; }
        public int ItemSelected
        {
            get { return cmbArticles.SelectedIndex; }
            set { cmbArticles.SelectedIndex = value; }
        }
        public IEnumerable<Article> Articles
        {
            get
            {
                var bs = (BindingSource)cmbArticles.DataSource;
                var list = (IEnumerable<Article>)bs.DataSource;
                return list;
            }
            set
            {
                var bs = new BindingSource();
                bs.DataSource = new SortableBindingList<Article>(value.ToList());
                cmbArticles.DataSource = bs;
            }
        }
        public OrderArticleCreatePresenter Presenter { get; set; }

        public string Error { get; set; }
        public bool ShowError
        {
            get { return lblResult.Visible; }
            set
            {
                if (value == true)
                {
                    lblResult.Text = Error;
                    lblResult.ForeColor = Color.Red;
                    this.ShowResult();
                }
            }
        }
        public string Success { get; set; }
        public bool ShowSuccess { get; set; }

        public event EventHandler AcceptClick;
        public event EventHandler CancelClick;

        private Timer _timer;

        public OrderArticleCreateView()
        {
            InitializeComponent();
            BindingEvents();
            Presenter = new OrderArticleCreatePresenter(this);
        }

        public void ShowView()
        {
            this.ShowDialog();
        }

        public void CloseView()
        {
            this.Close();
        }

        private void BindingEvents()
        {
            btnAccept.Click += delegate { AcceptClick?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelClick?.Invoke(this, EventArgs.Empty); };
        }

        private void ShowResult(int interval = 5)
        {
            lblResult.Visible = true;

            if (_timer != null && _timer.Enabled)
            {
                _timer.Stop();
            }

            _timer = new Timer();
            _timer.Interval = interval * 1000;
            _timer.Tick += (s, e) =>
            {
                lblResult.Hide();
                _timer.Stop();
            };
            _timer.Start();
        }

        private void txtNumberOfArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
             
            }
        }
    }
}
