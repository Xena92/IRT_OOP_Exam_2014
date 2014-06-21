using System;
using System.Linq;


namespace WarehouseManagement
{
    internal static class ItemGenerator
    {
        private static int _nextId;

        private static readonly string[] Prefix =
        {
            "Micro",
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Gigantic",
            "Huge",
            "wide",

        };

        private static readonly string[] Prefix2 =
        {
            "Yellow",
            "Green",
            "Blue",
            "Red",
            "Throwing",
            "White",
            "Pink",
            "Puny",
            "Black",
            "Purple"
        };

        private static readonly string[] Noun = 
        {
            "Lasso",
            "Disk",
            "Radio",
            "Bottle",
            "Baseball",
            "Scooter",
            "Chair",
            "Cycle",
            "Ball",
            "Screen",
            "Stick",
            "Shovel",
            "Dwarf"
        };

        private static Random _random = new Random();

        private static string PickPrefix()
        {
            return Prefix[_random.Next(Prefix.Count())];
        }

        private static string PickPrefix2()
        {
            return Prefix2[_random.Next(Prefix2.Count())];
        }

        private static string PickNoun()
        {
            return Noun[_random.Next(Noun.Count())];
        }

        // assemble word from the 3 lists Noun Prefix and Prefix2
        public static string ItemName()
        {
            return PickPrefix() + " " + PickPrefix2() + " " + PickNoun();
        }

        // methode for generating item propeties and put items into array 
        public static Item[] GetItems(int amount)
        {
            var result = new Item[amount];
            for (int i = 0; i < amount; i++)
            {
                _random = new Random(_random.Next(int.MinValue, int.MaxValue));
                var name = ItemName();
                var id = _nextId++;
                var weight = _random.NextDouble()*_random.NextDouble()*29 + 1;

                result[i] = new Item
                {
                    Adress = null,
                    Amount = 9999,
                    Id = id,
                    Name = name,
                    Popularity = 0,
                    Value = 0,
                    Weight = weight
                };
            }
            return result;
        }
    }
}