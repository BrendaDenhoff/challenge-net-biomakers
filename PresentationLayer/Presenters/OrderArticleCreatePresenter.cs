using BussinesLayer.Services;
using BussinesLayer.Services.Contracts;
using EntityLayer.Models;
using PresentationLayer.Views.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer.Presenters
{
    public class OrderArticleCreatePresenter
    {
        IOrderArticleCreateView _viewCreate;
        IOrderArticleService<IEnumerable<OrderArticle>> _orderArticleService { get; set; }
        IArticleService<IEnumerable<Article>> _articleService { get; set; }

        public OrderArticleCreatePresenter(IOrderArticleCreateView view, IOrderArticleService<IEnumerable<OrderArticle>> service)
        {
            _viewCreate = view;
            _viewCreate.Presenter = this;
            _orderArticleService = service;
            _articleService = new ArticleService();

            _viewCreate.Articles = _articleService.GetArticles();
            _viewCreate.AcceptClick += _viewCreate_AcceptClick;
            _viewCreate.CancelClick += _viewCreate_CancelClick;
        }

        public OrderArticleCreatePresenter(IOrderArticleCreateView view, IOrderArticleService<IEnumerable<OrderArticle>> orderArticleService, IArticleService<IEnumerable<Article>> articleService)
        {
            _viewCreate = view;
            _viewCreate.Presenter = this;
            _orderArticleService = orderArticleService;
            _articleService = articleService;

            _viewCreate.Articles = _articleService.GetArticles();
            _viewCreate.AcceptClick += _viewCreate_AcceptClick;
            _viewCreate.CancelClick += _viewCreate_CancelClick;
        }

        public OrderArticleCreatePresenter(IOrderArticleCreateView view)
        {
            _viewCreate = view;
            _viewCreate.Presenter = this;
            _orderArticleService = new OrderArticleService();
            _articleService = new ArticleService();

            _viewCreate.Articles = _articleService.GetArticles();
            _viewCreate.AcceptClick += _viewCreate_AcceptClick;
            _viewCreate.CancelClick += _viewCreate_CancelClick;
        }

        private void _viewCreate_CancelClick(object sender, EventArgs e)
        {
            _viewCreate.CloseView();
        }

        private void _viewCreate_AcceptClick(object sender, EventArgs e)
        {
            var article = _viewCreate.Articles.ToArray()[_viewCreate.ItemSelected];
            int stockArticle = _orderArticleService.GetArticlesStock(article.Id);
            if (_viewCreate.IsEditMode)
            {
                _viewCreate.Articles = _articleService.GetArticles();
                if (Convert.ToInt32(_viewCreate.NumberOfArticle) > stockArticle)
                {
                    _viewCreate.Error = $"There are only {stockArticle} units in stock.";
                    _viewCreate.ShowError = true;
                    return;
                }
                _orderArticleService.UpdateOrderArticle(_viewCreate.Id.ToString(), _viewCreate.OrderId.ToString(), article.Id.ToString(), _viewCreate.NumberOfArticle);
                _viewCreate.Success = $"'Article id={_viewCreate.Id}' has been updated.";
                _viewCreate.ShowSuccess = true;
                _viewCreate.IsEditMode = false;
            }
            else
            {
                if (string.IsNullOrEmpty(_viewCreate.OrderId))
                {
                    _viewCreate.Error = "The 'Name' field cannot be empty";
                    _viewCreate.ShowError = true;
                    return;
                }
                else if (Convert.ToInt32(_viewCreate.NumberOfArticle) > stockArticle)
                {
                    _viewCreate.Error = $"There are only {stockArticle} units in stock.";
                    _viewCreate.ShowError = true;
                    return;
                }
                _orderArticleService.CreateOrderArticle(_viewCreate.OrderId, article.Id.ToString(), _viewCreate.NumberOfArticle.ToString());
                _viewCreate.Success = $"The item '{article.Name}' has been added to the order";
                _viewCreate.ShowSuccess = true;
            }
           
            _viewCreate.CloseView();
        }

        public void LoadArticleFromEdit(OrderArticle orderArticle)
        {
            _viewCreate.Id = orderArticle.Id.ToString();
            _viewCreate.OrderId = orderArticle.OrderId.ToString();
            _viewCreate.NumberOfArticle = orderArticle.NumberOfArticle.ToString();
            _viewCreate.ItemSelected = _viewCreate.Articles.ToList().FindIndex(c => c.Id == Convert.ToInt32(orderArticle.ArticleId));
            _viewCreate.IsEditMode = true;
        }

    }
}
