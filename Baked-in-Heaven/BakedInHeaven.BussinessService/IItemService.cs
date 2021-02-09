using Baked_in_Heaven.Entities;
using BakedInHeaven.BussinessService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedInHeaven.BussinessService
{
    public interface IItemService
    {
        List<ItemDto> GetItems();
        void AddItem(Item newItem);
        void UpdateItem(Item itemChange,int id);
        void Delete(int id);
        Item Getitem(int id);
    }
}
