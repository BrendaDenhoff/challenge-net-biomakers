using BussinesLayer.Services.Contracts;
using DataLayer.Repositories;
using DataLayer.Repositories.Contracts;
using EntityLayer.Models;
using System;
using System.Collections.Generic;

namespace BussinesLayer.Services
{
    public class OrderService : IOrderService<IEnumerable<Order>>
    {
        private readonly IOrderRepository<Order> _orderRepository = new OrderRepository();

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.GetAll();
        }

        public void CreateOrder()
        {
            _orderRepository.Insert(
                new Order()
                { 
                });
        }

        public void UpdateOrder() 
        {
            _orderRepository.Update(
                new Order
                {
                    DateCreated = DateTime.Now
                });
        }

        public void DeleteOrder(string id) 
        {
            id = string.IsNullOrEmpty(id) ? string.Empty : id;
            _orderRepository.Delete(Convert.ToInt32(id));

        }

        public IEnumerable<Order> SearchOrder(int includeOrderNumber, int includeDate, string search)
        {
            var filters = new Dictionary<string, object>()
            {
                { "includeOrderNumber", includeOrderNumber},
                { "includeDate", includeDate },
                { "search", search }
            };
            return _orderRepository.Search(filters);
        }
    }
}
