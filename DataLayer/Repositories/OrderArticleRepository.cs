using Dapper;
using DataLayer.Repositories.Contracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataLayer.Repositories
{
    public class OrderArticleRepository : BaseRepository, IOrderArticleRepository<OrderArticle>
    {
        public void Insert(OrderArticle entity)
        {
            using (var connection = new SqlConnection(_connectionString)) 
            {
                connection.Open();
                connection.Execute(
                    "InsertOrderArticle",
                    new
                    {
                        OrderId = entity.OrderId,
                        ArticleId = entity.ArticleId,
                        NumberOfArticle = entity.NumberOfArticle
                    },
                    null,
                    null,
                    CommandType.StoredProcedure
                );
            }
        }

        public void Update(OrderArticle entity) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(
                    "UpdateOrderArticle",
                    new
                    {
                        Id = entity.Id,
                        ArticleId = entity.ArticleId,
                        NumberOfArticle = entity.NumberOfArticle
                    },
                    null,
                    null,
                    CommandType.StoredProcedure
                );
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(
                    "DeleteOrderArticle",
                    new
                    {
                        Id = id
                    },
                    null,
                    null,
                    CommandType.StoredProcedure
                );
            }
        }

        public IEnumerable<OrderArticle> GetAll()
        {
            IEnumerable<OrderArticle> result = new List<OrderArticle>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<OrderArticle>("GetOrdersArticle", CommandType.StoredProcedure);
            }
            return result;
        }

        public int GetArticlesStock(int id)
        {
            int result; 
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QuerySingle<int>("GetStockArticle",
                new { IdArticle = id },
                commandType: CommandType.StoredProcedure
            );
            }
            return result;
        }

        public IEnumerable<OrderArticle> GetOrderArticlesById()
        {
            IEnumerable<OrderArticle> result = new List<OrderArticle>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<OrderArticle>("GetOrdersArticle", CommandType.StoredProcedure);
            }
            return result;
        }

        public IEnumerable<OrderArticle> Search(Dictionary<string, object> filters)
        {
            IEnumerable<OrderArticle> result = new List<OrderArticle>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<OrderArticle>(
                    "SearchOrderArticle",
                    new
                    {
                        IncludeArticleName = (int)filters["includeArticleName"],
                        IncludeArticleDescription = (int)filters["includeArticleName"],
                        OrderId = filters["orderId"],
                        Search = (string)filters["search"]
                    },
                    null,
                    false,
                    null,
                    CommandType.StoredProcedure
                ).ToList();
            }
            return result;
        }

        public OrderArticle GetById(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<OrderArticle> GetByIdOrder(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var ordersArticles = connection.Query<OrderArticle>(
                    "GetOrderArticlesByOrderId",
                    new { IdOrden = id },
                    commandType: CommandType.StoredProcedure);

                return ordersArticles.ToList();
            }
        }
    }
}
