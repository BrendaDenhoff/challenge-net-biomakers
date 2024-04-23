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
    public class OrderArticleListPresenter
    {
        IOrderArticleListView _viewList;
        IOrderArticleCreateView _viewCreate { get; set; }
        IOrderArticleService<IEnumerable<OrderArticle>> _service {  get; set; }

        public OrderArticleListPresenter(IOrderArticleListView viewList, IOrderArticleService<IEnumerable<OrderArticle>> service)
        {
            _viewList = viewList;
            _service = service;

            _viewList.AddClick += _viewList_AddClick;
            _viewList.EditClick += _viewList_EditClick;
            _viewList.DeleteClick += _viewList_DeleteClick;
            _viewList.SearchClick += _viewList_SearchClick;
            _viewList.ShowAllClick += _viewList_ShowAllClick;
            _viewList.ViewLoad += _viewList_ViewLoad;
        }

        public OrderArticleListPresenter(IOrderArticleListView view)
        {
            _viewList = view;
            _viewList.Presenter = this;
            _service = new OrderArticleService();

            _viewList.AddClick += _viewList_AddClick;
            _viewList.EditClick += _viewList_EditClick;
            _viewList.DeleteClick += _viewList_DeleteClick;
            _viewList.SearchClick += _viewList_SearchClick;
            _viewList.ShowAllClick += _viewList_ShowAllClick;
            _viewList.ViewLoad += _viewList_ViewLoad;
        }

        private void _viewList_ViewLoad(object sender, EventArgs e)
        {
            _viewList.OrderArticles = _service.GetOrderArticlesById(_viewList.Id);
        }

        private void _viewList_ShowAllClick(object sender, EventArgs e)
        {
            _viewList.OrderArticles = _service.GetOrderArticlesById(_viewList.Id);
            _viewList.ShowSuccess = false;
        }

        private void _viewList_SearchClick(object sender, EventArgs e)
        {
            this.SearchArticle();
        }

        private void _viewList_DeleteClick(object sender, EventArgs e)
        {
            try
            {
                var orderArticle = _viewList.OrderArticles.ToArray()[_viewList.ItemSelected];
                var result = System.Windows.Forms.MessageBox.Show($"Do you want to delete article '{orderArticle.ArticleName}'?", "Alert", System.Windows.Forms.MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DeleteArticle();
                    _viewList.Success = $"The article '{orderArticle.ArticleName}' has been removed";
                    _viewList.ShowSuccess = true;
                }
            }
            catch
            {
                _viewList.Success = $"There is no article to delete.";
                _viewList.ShowSuccess = true;
            }
            finally
            {
                this.LoadArticles();
            }
        }

        private void _viewList_EditClick(object sender, EventArgs e)
        {
            try
            {
                var orderArticle = _viewList.OrderArticles.ToArray()[_viewList.ItemSelected];
                _viewCreate = new OrderArticleCreateView();
                _viewCreate.Presenter.LoadArticleFromEdit(orderArticle);
                _viewCreate.ShowView();

                if (!string.IsNullOrEmpty(_viewCreate.Success))
                {
                    _viewList.Success = _viewCreate.Success;
                    _viewList.ShowSuccess = true;
                    _viewList.OrderArticles = _service.GetOrderArticlesById(_viewList.Id);
                }
            }
            catch
            {
                _viewList.Success = "There is nothing to edit.";
                _viewList.ShowSuccess = true;
            }
            finally
            {
                this.LoadArticles();
            }
        }

        private void _viewList_AddClick(object sender, EventArgs e)
        {
            _viewCreate = new OrderArticleCreateView();
            _viewCreate.OrderId = _viewList.Id.ToString();
            _viewCreate.ShowView();

            if (!string.IsNullOrEmpty(_viewCreate.Success))
            {
                _viewList.Success = _viewCreate.Success;
                _viewList.ShowSuccess = true;
                this.LoadArticles();
            }
        }

        public void DeleteArticle()
        {
            var orderArticle = _viewList.OrderArticles.ToList()[_viewList.ItemSelected];
            _service.DeleteOrderArticle(orderArticle.Id.ToString());
            _viewList.Success = "Article has been removed";
            _viewList.ShowSuccess = true;
        }

        public void LoadArticles()
        {
            _viewList.OrderArticles = _service.GetOrderArticlesById(_viewList.Id);
            _viewList.IncludeArticleName = false;
            _viewList.IncludeArticleDescription = false;
        }

        public OrderArticle GetOrderArticleSelected()
        {
            return _viewList.OrderArticles.ToArray()[_viewList.ItemSelected];
        }

        public void SearchArticle()
        {
            var result = _service.SearchOrderArticle(Convert.ToInt32(_viewList.IncludeArticleName), Convert.ToInt32(_viewList.IncludeArticleDescription), _viewList.Search, _viewList.Id);
            _viewList.Error = "";

            if (_viewList.IncludeArticleName == false && _viewList.IncludeArticleDescription == false)
            {
                _viewList.Warning = "Please select a search filter";
                _viewList.ShowWarning = true;
                return;
            }
            else if ((_viewList.IncludeArticleName || _viewList.IncludeArticleDescription) && result.Count() == 0)
            {
                _viewList.Success = "No results found";
                _viewList.ShowSuccess = true;
            }
            else
            {
                _viewList.Success = $"'{result.Count()}' results found";
                _viewList.ShowSuccess = true;
            }
            _viewList.OrderArticles = result;
        }
    }
}
