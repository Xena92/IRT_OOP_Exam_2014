using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    internal static class OrderGenerator 
    {
        /*This function generates a random amount of orders each containing 1-20 items, everytime an item is bought it's popularity goes 1 up 
          allowing the warehouse to track which items it sells the most.*/

        public static List<Item[]> GetOrders(int orders, Warehouse warehouse)
        {
            Random random = new Random();
            var result = new List<Item[]>();
            for (int i = 0; i < orders; i++)
            {
                random = new Random(random.Next(int.MinValue, int.MaxValue));
                var amount = random.Next(1, 20);
                var order = new Item[amount];
                for (int j = 0; j < amount; j++)
                {
                    var index = random.Next(warehouse.ItemsInInventory.Count);
                    var item = warehouse.ItemsInInventory[index];
                    if (order.Contains(item))
                    {
                        j--;
                        continue;
                    }
                    item.Popularity++;
                    order[j] = item;
                }
                result.Add(order);
            }
            return result;
        }
    }
}