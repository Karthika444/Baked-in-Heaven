using Baked_in_Heaven.Data_access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedInHeaven.BussinessService
{
    public interface IOrderService
    {
        List<Order> GetUsers();
    }
}
