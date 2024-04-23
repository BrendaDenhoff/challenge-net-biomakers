using BussinesLayer.Services;
using BussinesLayer.Services.Contracts;
using EntityLayer.Models;
using PresentationLayer.Views;
using PresentationLayer.Views.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer.Presenters
{
    public class OrderListPresenter
    {
        IOrderListView _viewList { get; set; }
        IOrderArticleListView _viewOrderArticleList {  get; set; }
        IOrderService<IEnumerable<Order>> _service {  get; set; }   

        public OrderListPresenter(IOrderListView viewList, IOrderService<IEnumerable<Order>> service)
        {
            _viewList = viewList;
            _service = service;

            _viewList.AddClick += _viewList_AddClick;
            _viewList.AddArticleClick += _viewList_AddArticleClick;
            _viewList.DeleteClick += _viewList_DeleteClick;
            _viewList.SearchClick += _viewList_SearchClick;
            _viewList.ShowAllClick += _viewList_ShowAllClick;
            _viewList.ViewLoad += _viewList_ViewLoad;
        }

        public OrderListPresenter(IOrderListView view)
        {
            _viewList = view;
            _viewList.Presenter = this;
            _service = new OrderService();

            _viewList.AddClick += _viewList_AddClick;
            _viewList.AddArticleClick += _viewList_AddArticleClick;
            _viewList.DeleteClick += _viewList_DeleteClick;
            _viewList.SearchClick += _viewList_SearchClick;
            _viewList.ShowAllClick += _viewList_ShowAllClick;
            _viewList.ViewLoad += _viewList_ViewLoad;
        }

        private void _viewList_ViewLoad(object sender, EventArgs e)
        {
            _viewList.Orders = _service.GetOrders();
        }

        private void _viewList_ShowAllClick(object sender, EventArgs e)
        {
            _viewList.Orders = _service.GetOrders();
            _viewList.ShowSuccess = false;
        }

        private void _viewList_SearchClick(object sender, EventArgs e)
        {
            this.SearchOrder();
        }

        private void _viewList_DeleteClick(object sender, EventArgs e)
        {
            try
            {
                var order = _viewList.Orders.ToArray()[_viewList.ItemSelected];
                var result = System.Windows.Forms.MessageBox.Show($"Do you want to delete order '{order.Id}'?", "Alert", System.Windows.Forms.MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DeleteOrder();
                    _viewList.Success = $"The order '{order.Id}' has been removed";
                    _viewList.ShowSuccess = true;
                }
            } 
            catch  
            {
                _viewList.Success = $"There is no order to delete.";
                _viewList.ShowSuccess = true;
            }
            this.LoadOrders();
        }

        private void _viewList_AddClick(object sender, EventArgs e)
        {
            _service.CreateOrder();
            this.LoadOrders();
        }

        private void _viewList_AddArticleClick(object sender, EventArgs e)
        {
            try
            {
                _viewOrderArticleList = new OrderArticleListView();
                _viewOrderArticleList.Id = _viewList.Orders.ToArray()[_viewList.ItemSelected].Id;
                _viewOrderArticleList.ShowView();
            }
            catch
            {
                _viewList.Success = "There are no orders created.";
                _viewList.ShowSuccess = true;
            }
        }

        public void DeleteOrder()
        {
            var order = _viewList.Orders.ToList()[_viewList.ItemSelected];
            _service.DeleteOrder(order.Id.ToString());
            _viewList.Success = "Order has been removed";
            _viewList.ShowSuccess = true;
        }

        public void LoadOrders()
        {
            _viewList.Orders = _service.GetOrders();
            _viewList.IncludeOrderNumber = false;
            _viewList.IncludeDate = false;
        }

        public void SearchOrder()
        {
            var result = _service.SearchOrder(Convert.ToInt32(_viewList.IncludeOrderNumber), Convert.ToInt32(_viewList.IncludeDate), _viewList.Search);
            _viewList.Error = "";

            if (_viewList.IncludeOrderNumber == false && _viewList.IncludeDate == false)
            {
                _viewList.Warning = "Please select a search filter";
                _viewList.ShowWarning = true;
                return;
            }
            else if ((_viewList.IncludeOrderNumber || _viewList.IncludeDate) && result.Count() == 0)
            {
                _viewList.Success = "No results found";
                _viewList.ShowSuccess = true;
            }
            else
            {
                _viewList.Success = $"'{result.Count()}' results found";
                _viewList.ShowSuccess = true;
            }
            _viewList.Orders = result;
        }
    }
}
