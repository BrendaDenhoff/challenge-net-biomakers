using BussinesLayer.Services.Contracts;
using DataLayer.Repositories;
using DataLayer.Repositories.Contracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;

namespace BussinesLayer.Services
{
    public class OrderArticleService : IOrderArticleService<IEnumerable<OrderArticle>>
    {
        private readonly IOrderArticleRepository<OrderArticle> _orderArticleRepository = new OrderArticleRepository();

        public IEnumerable<OrderArticle> GetOrderArticles()
        {
            return _orderArticleRepository.GetAll();
        }

        public IEnumerable<OrderArticle> GetOrderArticlesById(int id)
        {
            return _orderArticleRepository.GetByIdOrder(id);
        }

        public int GetArticlesStock(int id)
        {
            return _orderArticleRepository.GetArticlesStock(id);
        }

        public void CreateOrderArticle(string orderId, string articleId, string numberOfArticle)
        {
            _orderArticleRepository.Insert(
                new OrderArticle()
                {
                    OrderId = Convert.ToInt32(orderId),
                    ArticleId = Convert.ToInt32(articleId),
                    NumberOfArticle = Convert.ToInt32(numberOfArticle)
                });
        }

        public void UpdateOrderArticle(string id, string orderId, string articleId, string numberOfArticle)
        {
            _orderArticleRepository.Update(
                new OrderArticle
                {
                    Id = Convert.ToInt32(id),
                    OrderId = Convert.ToInt32(orderId),
                    ArticleId = Convert.ToInt32(articleId),
                    NumberOfArticle = Convert.ToInt32(numberOfArticle)
                });
        }

        public void DeleteOrderArticle(string id)
        {
            id = string.IsNullOrEmpty(id) ? string.Empty : id;
            _orderArticleRepository.Delete(Convert.ToInt32(id));

        }

        public IEnumerable<OrderArticle> SearchOrderArticle(int includeName, int includeDescription, string search, int orderId)
        {
            var filters = new Dictionary<string, object>()
            {
                { "includeArticleName", includeName},
                { "includeArticleDescription", includeDescription },
                { "orderId", orderId },
                { "search", search }
            };
            return _orderArticleRepository.Search(filters);
        }
    }
}
