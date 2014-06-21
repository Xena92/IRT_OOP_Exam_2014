using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class InStock
    {
        //Vil gerne have listen af items herinde i stedet, da InStock klassen så beskriver de items der findes i hele varehuset.
        //Item klassen skal så blot indeholde de properties der udgør et item, altså navn, id, pris, vægt, osv..
        public List<Item> GetItems()    //Creates a list of hardcoded items.
        {
            List<Item> Items = new List<Item>();

            /*Items.Add(new Item() { Id = "TL001", Name = "Standard Hammer", Weight = 8, Value = 0, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL002", Name = "Sledge Hammer", Weight = 20, Value = 0, Amount = 9999, Popularity = 10 });
            Items.Add(new Item() { Id = "TL003", Name = "Small Hammer", Weight = 3, Value = 0, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL010", Name = "Cross Screwdriver", Weight = 66, Value = 0, Location = 0400401, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL011", Name = "Flathead Screwdriver", Weight = 42, Value = 0, Location = 0400401, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL012", Name = "Cross Screwdriver", Weight = 99, Value = 0, Location = 0400401, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL020", Name = "Tape measure 2m", Weight = 40, Value = 0, Location = 0400501, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL021", Name = "Tape measure 5m", Weight = 20, Value = 0, Location = 0400501, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL022", Name = "Tape measure 10m", Weight = 1, Value = 0, Location = 0400501, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL023", Name = "Tape measure 25m", Weight = 2, Value = 0, Location = 0400501, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL030", Name = "Level", Weight = 1, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL031", Name = "Utility Knife", Weight = 1, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL032", Name = "Putty Knife", Weight = 3, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL033", Name = "Nail Sets", Weight = 2, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL034", Name = "Combination Square", Weight = 1, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL035", Name = "C-Clamp", Weight = 3, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL036", Name = "Flashlight", Weight = 3, Value = 0, Location = 0400601, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL040", Name = "Pilers", Weight = 1, Value = 0, Location = 0400701, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL041", Name = "Adjustable Crescent Wrench", Weight = 2, Value = 0, Location = 0400701, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL042", Name = "Wire Stripper", Weight = 1, Value = 0, Location = 0400701, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL043", Name = "Hex Key Tool", Weight = 2, Value = 0, Location = 0400701, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL050", Name = "Power Drill", Weight = 7, Value = 0, Location = 0400801, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL051", Name = "Electrical Cord 2m", Weight = 1, Value = 0, Location = 0400801, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL052", Name = "Electrical Cord 5m", Weight = 2, Value = 0, Location = 0400801, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL053", Name = "Electrical Cord 10m", Weight = 5, Value = 0, Location = 0400801, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL054", Name = "Electrical Cord 25m", Weight = 12, Value = 0, Location = 0400801, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "TL055", Name = "Electrical Cord 50m", Weight = 20, Value = 0, Location = 0400901, Amount = 9999, Popularity = 25 });
            Items.Add(new Item() { Id = "TL056", Name = "Electrical Cord 100m", Weight = 40, Value = 0, Location = 0400901, Amount = 9999, Popularity = 3 });
            Items.Add(new Item() { Id = "TL056", Name = "Electrical Cord 200m", Weight = 80, Value = 0, Location = 0400901, Amount = 9999, Popularity = 15 });
            Items.Add(new Item() { Id = "AT001", Name = "100 Screws", Weight = 2, Value = 0, Location = 0401001, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "AT002", Name = "100 Nails", Weight = 2, Value = 0, Location = 0401001, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "AT003", Name = "1000 Nuts", Weight = 5, Value = 0, Location = 0401001, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "AT004", Name = "Building Bracket", Weight = 2, Value = 0, Location = 0401002, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "AT005", Name = "Wedges", Weight = 1, Value = 0, Location = 0401002, Amount = 9999, Popularity = 0 });
            Items.Add(new Item() { Id = "AT006", Name = "Duck Tape", Weight = 1, Value = 0, Location = 0401002, Amount = 9999, Popularity = 0 });
            */
            return Items;
        }
    }
}
