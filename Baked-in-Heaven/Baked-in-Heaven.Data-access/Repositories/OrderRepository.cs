using Baked_in_Heaven.Data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baked_in_Heaven.Data_access.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly applicationdbcontext _dbContext;
        public OrderRepository(applicationdbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }
    }


}

