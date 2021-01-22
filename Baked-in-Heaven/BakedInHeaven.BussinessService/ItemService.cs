using Baked_in_Heaven.Data_access.Repositories;
using Baked_in_Heaven.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BakedInHeaven.BussinessService.Dtos;

namespace BakedInHeaven.BussinessService
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Add(Item newItem)
        {
            List<Item> data = new List<Item>();
            data = _itemRepository.GetItems(); // fetch the entire database
            int Total = data.Where(x => x.Availabledate == newItem.Availabledate).Count();

            var count = 0;
            var flag = 0;

            if (Total < 15)
            {
                foreach (var Element in data)
                {
                    if (Element.Name == newItem.Name)
                    {
                        break;
                        // " with same name already exist for the date";
                    }

                    else { flag = 1; }

                }
            }
            if (flag == 1)
            {

                if (newItem.IsSpecial == true)
                {
                    foreach (var Element in data)
                    {
                        if (Element.Availabledate == newItem.Availabledate)
                        {
                            if (Element.IsSpecial == true)
                            {
                                count++;
                            }
                        }

                    }
                    if (count > 4)
                    {

                    }


                }
                else
                {
                    _itemRepository.Add(newItem);
                }
            }

        }

        public void Delete(int id)
        {
            _itemRepository.Delete(id);

        }

        public List<ItemDto> GetItems()
        {
            var items = _itemRepository.GetAllItems();

            return items.Select(x => new ItemDto
            {
                Id = x.Id,
                Availabledate = x.Availabledate,
                IsSpecial = x.IsSpecial,
                IsVeg = x.IsVeg,
                Kcal = x.Kcal,
                Price = x.Price,
                Quantity = x.Quantity,
                Name = x.Name,
                WeightInGrams = x.WeightInGrams
            }).ToList();

        }

        public void Update(Item itemChange, int id)
        {
            List<Item> data = new List<Item>();
            data = _itemRepository.GetItems(); // fetch the entire database
            int Total = data.Where(x => x.Availabledate == itemChange.Availabledate).Count();

            var count = 0;
            var flag = 0;

            if (Total < 15)
            {
                foreach (var Element in data)
                {
                    if (Element.Name == itemChange.Name)
                    {
                        break;
                        // " with same name already exist for the date";
                    }

                    else { flag = 1; }

                }
            }
            if (flag == 1)
            {

                if (itemChange.IsSpecial == true)
                {
                    foreach (var Element in data)
                    {
                        if (Element.Availabledate == itemChange.Availabledate)
                        {
                            if (Element.IsSpecial == true)
                            {
                                count++;
                            }
                        }

                    }
                    if (count > 4)
                    {

                    }


                }
                else
                {
                    _itemRepository.Update(itemChange,id);
                }
            }

        }
    }
}
