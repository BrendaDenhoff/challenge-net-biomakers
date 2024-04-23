using PresentationLayer.Views;
using PresentationLayer.Views.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    public class MainPresenter
    {
        IMainView _viewMain;
        IArticleListView _viewArticleList;
        IOrderListView _viewOrderList;
        ICategoryListView _viewCategoryList;
        IReportView _viewReports;

        public MainPresenter(IMainView view, IArticleListView viewArticleList, ICategoryListView viewCategoryList, IReportView viewReports, IOrderListView viewOrderList)
        {
            _viewMain = view;
            _viewMain.Presenter = this;
            _viewArticleList = viewArticleList;
            _viewCategoryList = viewCategoryList;
            _viewReports = viewReports;
            _viewOrderList = viewOrderList;

            _viewMain.ArticlesClick += _viewMain_ArticlesClick;
            _viewMain.CategoriesClick += _viewMain_CategoriesClick;
            _viewMain.ReportsClick += _viewMain_ReportsClick;
            _viewMain.OrdersClick += _viewMain_OrdersClick;
        }

        public MainPresenter(IMainView view)
        {
            _viewMain = view;
            _viewMain.Presenter = this;
            _viewArticleList = new ArticleListView();
            _viewCategoryList = new CategoryListView();
            _viewReports = new ReportView();
            _viewOrderList = new OrderListView();

            _viewMain.ArticlesClick += _viewMain_ArticlesClick;
            _viewMain.CategoriesClick += _viewMain_CategoriesClick;
            _viewMain.ReportsClick += _viewMain_ReportsClick;
            _viewMain.OrdersClick += _viewMain_OrdersClick;
        }

        private void _viewMain_ArticlesClick(object sender, EventArgs e)
        {
            _viewArticleList.ShowView();
        }

        private void _viewMain_CategoriesClick(object sender, EventArgs e)
        {
            _viewCategoryList.ShowView();
        }

        private void _viewMain_ReportsClick(object sender, EventArgs e)
        {
            _viewReports.ShowView();
        }

        private void _viewMain_OrdersClick(object sender, EventArgs e)
        {
            _viewOrderList.ShowView();
        }
    }
}
