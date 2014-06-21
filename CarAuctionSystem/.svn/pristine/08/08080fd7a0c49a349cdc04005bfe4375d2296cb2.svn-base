using System;
using System.Collections.Generic;

namespace WarehouseManagement
{
    public class Warehouse
    {
        public int Aisles { get; private set; }
        public int Spaces { get; private set; }
        public int ShipLocation { get; private set; }

        public List<Item> ItemsInInventory;

        public Warehouse(int aisles, int spaces, int shipping)
        {
            Aisles = aisles;
            Spaces = spaces;
            ShipLocation = shipping;
            ItemsInInventory = new List<Item>();
            var items = ItemGenerator.GetItems(aisles*spaces*2);
            foreach (var item in items)
            {
                ItemsInInventory.Add(item);
            }
        }

        public void PrintItems()
        {
            Console.WriteLine("\n---------------------------------------------------\n" +
                              "Items in warehouse\n" +
                              "---------------------------------------------------");
            foreach (var item in ItemsInInventory)
            {
                Console.WriteLine("{0} - {1,-30} Popularity: {2}", item, item.Name, item.Popularity);
            }
        }
    }
}
