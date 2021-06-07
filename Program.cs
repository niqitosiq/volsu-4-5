using System;
using System.Collections.Generic;
using System.Net.Sockets;


// вывод информации о товаре по номеру с помощью индекса;
// вывод на экран информации о товаре, название которого введено с клавиатуры; если таких товаров нет, выдать соответствующее сообщение;
// сортировку товаров по названию магазина, по наименованию и по цене;
// перегруженную операцию сложения товаров, выполняющую сложение их цен.
namespace Labs4Sem.Lab5
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Item> Items = new List<Item>();
      Items.Add(new Item { Name = "a", Price = 50, Shop = "1" });
      Items.Add(new Item { Name = "b", Price = 150, Shop = "4" });
      Items.Add(new Item { Name = "a", Price = 1, Shop = "7" });
      Warehouse warehouse = new Warehouse(Items);

      while (true)
      {
        Console.Write("Выберите операцию:\n" +
                      "1.Вывод информации о товаре по номеру с помощью индекса;\n" +
                      "2.Вывод на экран информации о товаре, название которого введено с клавиатуры;\n" +
                      "3.Сортировку товаров по названию магазина, по наименованию и по цене;\n" +
                      ">>");
        int select = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(select);
        switch (select)
        {
          case 1:
            Console.WriteLine("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Item itemByIndex = warehouse.GetItem(index);
            if (itemByIndex != null)
            {
              Console.WriteLine(itemByIndex.ToString());
            }
            else
            {
              Console.WriteLine("Такого товара не найдено");
            }
            break;
          case 2:
            Console.WriteLine("Введите название с клавиатуры: ");
            String name = Console.ReadLine();
            Item itemByName = warehouse.FindByName(name);
            if (itemByName != null)
            {
              Console.WriteLine(itemByName.ToString());
            }
            else
            {
              Console.WriteLine("Товар с таким именем не найден :(");
            }
            break;
          case 3:
            Console.Write("Сортировать по:\n" +
                          "1.Название товара;\n" +
                          "2.Цене;\n" +
                          "3.По названию магазина;\n" +
                          ">>");
            int sortType = Convert.ToInt32(Console.ReadLine());
            switch (sortType)
            {
              case 1:
                warehouse.sortByName();
                break;
              case 2:
                warehouse.sortByPrice();
                break;
              case 3:
                warehouse.sortByShop();
                break;
            }
            Console.WriteLine(warehouse.ToString());
            break;
        }
      }

    }
  }
}
