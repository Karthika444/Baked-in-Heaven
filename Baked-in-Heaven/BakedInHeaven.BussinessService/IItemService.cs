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
        void Add(Item newItem);
        void Update(Item itemChange,int id);
        void Delete(int id);
    }
}
