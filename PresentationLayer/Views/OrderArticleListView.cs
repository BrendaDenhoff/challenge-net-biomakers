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
    public partial class OrderArticleListView : Form, IOrderArticleListView
    {
        private int _itemSelected;
        public int Id { get; set; }
        public int ItemSelected
        {
            get { return dgvOrders.CurrentCell.RowIndex; }
            set
            {
                if (value >= 0 && value <= dgvOrders.RowCount)
                {
                    dgvOrders.CurrentCell = dgvOrders.Rows[value].Cells[0];
                    _itemSelected = value;
                }
            }
        }
        public bool IncludeArticleName
        {
            get { return Convert.ToBoolean(chkArticleName.CheckState); }
            set { chkArticleName.CheckState = (CheckState)Convert.ToInt32(value); }
        }
        public bool IncludeArticleDescription
        {
            get { return Convert.ToBoolean(chkArticleDescription.CheckState); }
            set { chkArticleDescription.CheckState = (CheckState)Convert.ToInt32(value); }
        }
        public string Search
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public IEnumerable<OrderArticle> OrderArticles
        {
            get
            {
                var bs = (BindingSource)dgvOrders.DataSource;
                var list = (IEnumerable<OrderArticle>)bs.DataSource;
                return list;
            }
            set
            {
                var bs = new BindingSource();
                bs.DataSource = new SortableBindingList<OrderArticle>(value.ToList());
                dgvOrders.DataSource = bs;
                dgvOrders.Columns["ArticleId"].Visible = false;
            }
        }
        public OrderArticleListPresenter Presenter { get; set; }
        public string Warning { get; set; }
        public bool ShowWarning
        {
            get { return lblResult.Visible; }
            set
            {
                if (value == true)
                {
                    lblResult.Text = Warning;
                    lblResult.ForeColor = Color.Goldenrod;
                    this.ShowResult();
                }
            }
        }
        public string Error { get; set; }
        public bool ShowError { get; set; }
        public string Success { get; set; }
        public bool ShowSuccess
        {
            get { return lblResult.Visible; }
            set
            {
                if (value == true)
                {
                    lblResult.Text = Success;
                    lblResult.ForeColor = Color.Green;
                    this.ShowResult();
                }
                else
                {
                    if (_timer != null && _timer.Enabled)
                        _timer.Stop();
                    lblResult.Visible = value;
                }
            }
        }

        public event EventHandler AddClick;
        public event EventHandler EditClick;
        public event EventHandler DeleteClick;
        public event EventHandler SearchClick;
        public event EventHandler ShowAllClick;
        public event EventHandler ViewLoad;

        private Timer _timer;

        public OrderArticleListView()
        {
            InitializeComponent();
            BindingEvents();
            Presenter = new OrderArticleListPresenter(this);
        }

        private void BindingEvents()
        {
            btnAdd.Click += delegate { AddClick?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate { EditClick?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate { DeleteClick?.Invoke(this, EventArgs.Empty); };
            btnShowAll.Click += delegate { ShowAllClick?.Invoke(this, EventArgs.Empty); };
            btnSearch.Click += delegate { SearchClick?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { ViewLoad?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                    SearchClick?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public void CloseView()
        {
            this.Close();
        }

        public void ShowView()
        {
            this.ShowDialog();
        }

        private void ShowResult(int interval = 3)
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

        #region UI Settings

        private void pnlSearchContainer_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Focus();
        }


        #endregion
    }
}
