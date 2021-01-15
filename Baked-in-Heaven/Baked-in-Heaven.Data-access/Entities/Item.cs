using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baked_in_Heaven.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public float WeightInGrams { get; set; }

        public float Kcal { get; set; }

        public bool IsVeg { get; set; }

        public bool IsSpecial { get; set; }

        public DateTime Availabledate { get; set; }

    }
}
