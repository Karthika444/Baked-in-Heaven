using Baked_in_Heaven.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baked_in_Heaven.Data_access.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        public int ItemId { get; set; }
        public Item  Item { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
