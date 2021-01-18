using Baked_in_Heaven.Data_access.Entities;
using Baked_in_Heaven.Data_access.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedInHeaven.BussinessService
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetUsers()
        {
            List<Order> orders = new List<Order>();
            orders = _orderRepository.GetAllOrders();
            return orders.ToList();


        }
    }
}
