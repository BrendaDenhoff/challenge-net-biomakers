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
    public class OrderRepository : BaseRepository, IOrderRepository<Order>
    {
        public void Insert(Order entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(
                    "InsertOrder",
                    new
                    {
                    },
                    null,
                    null,
                    CommandType.StoredProcedure
               );
            }
        }

        public void Update(Order entity)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute(
                    "UpdateOrder",
                    new
                    {
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
                    "DeleteOrder",
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

        public IEnumerable<Order> GetAll()
        {
            IEnumerable<Order> result = new List<Order>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<Order>("GetOrders", CommandType.StoredProcedure);
            }
            return result;
        }

        public IEnumerable<Order> Search(Dictionary<string, object> filters)
        {
            IEnumerable<Order> result = new List<Order>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<Order>(
                    "SearchOrder",
                    new
                    {
                        IncludeOrderNumber = (int)filters["includeOrderNumber"],
                        IncludeDate = (int)filters["includeDate"],
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

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
