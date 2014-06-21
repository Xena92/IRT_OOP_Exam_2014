using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement
{
    class Program
    {
        private static void Main()
        {
            var wh = new Warehouse(5, 15, 3);

            var myPlace = new PlacingOfItems(wh);

            wh.PrintItems();

            Console.ReadKey();

            var bag = new Knapsack.Bag();

            var orders = OrderGenerator.GetOrders(100, wh);

            foreach (var order in orders)
            {
                bag.AddOrder(order);
            }

            wh.PrintItems();

            Console.ReadKey();

            myPlace = new PlacingOfItems(wh);

            wh.PrintItems();

            Console.ReadKey();



            var sp = new ShortestPath(wh);

            var items = bag.GetGroup();

            sp.InsertItems(items.ToArray());

            var result = sp.GetResult();

            Console.WriteLine("\n---------------------------------------------------");
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            items = new List<Item>
            {
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(25, 1)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(10, 2)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(15, 2)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(20, 2)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(5, 3)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(25, 3)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(5, 4)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(10, 5)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(15, 5)),
                wh.ItemsInInventory.FirstOrDefault(i => i.Adress == new Adress(20, 5))
            };

            sp.InsertItems(items.ToArray());

            result = sp.GetResult();

            Console.WriteLine("\n---------------------------------------------------");
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
