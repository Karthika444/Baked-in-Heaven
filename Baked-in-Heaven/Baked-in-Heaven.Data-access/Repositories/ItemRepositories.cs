using Baked_in_Heaven.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baked_in_Heaven.Data_access.Repositories
{
    public class ItemRepositories :IItemRepository
    {
        private readonly applicationdbcontext _dbContext;
        public ItemRepositories(applicationdbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Item itemEntity)
        {
            _dbContext.Items.Add(itemEntity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            Item item = _dbContext.Items.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _dbContext.Remove(item);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Item>  GetItems()
        {
            return _dbContext.Items.ToList();
        }

        public List<Item> GetAllItems()
        {
            return _dbContext.Items.ToList();
        }
        public Item Update(Item itemChange,int id)
        {
            Item item = _dbContext.Items.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                item.Name = itemChange.Name;
                item.Kcal = itemChange.Kcal;
                item.Price = itemChange.Price;
                item.Quantity = itemChange.Quantity;
                item.WeightInGrams = itemChange.WeightInGrams;
                item.IsVeg = itemChange.IsVeg;
                item.IsSpecial = itemChange.IsSpecial;
                item.Availabledate = itemChange.Availabledate;
                _dbContext.SaveChanges();

            }
            return item;
        }
    }

}

