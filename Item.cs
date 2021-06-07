using System;
using System.Collections.Generic;
using System.Text;

namespace Labs4Sem.Lab5
{
  class Item
  {
    public Item(string name = "item", string shop = "shop", int price = 100)
    {
      Name = name;
      Shop = shop;
      Price = price;
    }
    public string Name { get; set; }
    public string Shop { get; set; }
    public int Price { get; set; }
    // public bool IsOnParking { get; set; }

    public override string ToString()
    {
      return $"Название: {Name}\n Магазин: {Shop}\nСтоимость: {Price.ToString()}\n";
    }

    public static Int64 operator +(Item c1, Item c2)
    {
      return c1.Price + c2.Price;
    }
  }
}
