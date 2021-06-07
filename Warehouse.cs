using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Labs4Sem.Lab5
{
  class Warehouse
  {
    List<Item> Items = new List<Item>();
    public Warehouse(List<Item> items)
    {
      Items.AddRange(items);
    }

    public void AddItems()
    {
      Items.Add(new Item { Name = "123", Price = 50, Shop = "1" });
      Items.Add(new Item { Name = "a", Price = 100, Shop = "2" });
      Items.Add(new Item { Name = "6", Price = 500, Shop = "3" });
    }

    public Item this[int index]
    {
      get => Items[index];
      set => Items[index] = value;
    }


    public void AddItem(Item item)
    {
      Items.Add(item);
    }

    public override string ToString()
    {
      string str = "";
      foreach (var item in Items)
      {
        str += $"{item.ToString()}{new string('-', 50)}\n";
      }
      return str;
    }

    public Item? GetItem(int index)
    {
      if (index >= Items.Count())
      {
        return null;
      }
      return Items[index];
    }

    public Item? FindByName(string name)
    {
      return Items.FirstOrDefault(i => i.Name.Equals(name));
    }

    private List<Item> updateItemsByQuery(IEnumerable<Item> query)
    {
      List<Item> sorted = new List<Item>();
      foreach (Item item in query)
      {
        sorted.Add(item);
      }
      Items = sorted;
      return sorted;
    }
    public List<Item> sortByPrice()
    {
      IEnumerable<Item> query = Items.OrderBy(item => item.Price);
      return updateItemsByQuery(query);
    }
    public List<Item> sortByName()
    {
      IEnumerable<Item> query = Items.OrderBy(item => item.Name);
      return updateItemsByQuery(query);
    }
    public List<Item> sortByShop()
    {
      IEnumerable<Item> query = Items.OrderBy(item => item.Shop);
      return updateItemsByQuery(query);
    }


  }
}
