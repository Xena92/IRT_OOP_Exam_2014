using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement
{
    public class PlacingOfItems
    {
        public List<Aisle> aisleList = new List<Aisle>();
        private int heavyAislesNumber;
        public List<Item> heavyItemList = new List<Item>();
        private int leftOverSpaceHeavy;
        public List<Item> lightItemList = new List<Item>();

        public PlacingOfItems(Warehouse warehouse)
        {
            if (warehouse.ShipLocation < 1 && warehouse.ShipLocation > warehouse.Aisles)
                throw new ArgumentOutOfRangeException("Invalid shipping aisle!");

            //Divides the list into heavy and light item lists
            foreach (Item k in warehouse.ItemsInInventory)
            {
                if (k.Weight >= 20)
                    heavyItemList.Add(k);
                else
                    lightItemList.Add(k);
            }

            SortByPopularity();

            //Makes aisles in the warehouse - triggers Aisle Class that triggers storageSpace Class that triggers item and adress class.
            for (int i = 0; i < warehouse.Aisles; i++)
                aisleList.Add(new Aisle(warehouse.Spaces, i + 1));

            //Sets the shipping areas coords.
            ShippingArea = aisleList[warehouse.ShipLocation - 1].PotentialShippingArea;

            //Sets the distance from storagespace to shipping area
            SetDistance();

            SetHeavyItems(warehouse.Spaces);

            SetLightItems();
        }

        public Coords ShippingArea { get; private set; }

        //Gives the spaces in the warehouse a distance to the shipping area.
        public void SetDistance()
        {
            foreach (StorageSpace k in aisleList.SelectMany(p => p.StorageSpaceList))
            {
                //Using Distance formula to give each space in the warehouse a distance to the shipping area.
                double a = Math.Pow(k.coords.x - ShippingArea.x, 2);
                double b = Math.Pow(k.coords.y - ShippingArea.y, 2);
                double distance = Math.Sqrt(a + b);

                //Makes sure that the value can never be negative.
                if (distance < 0)
                    distance *= -1;

                k.distance = distance;
            }
        }

        //Places light items in the warehouse. If this is not enough it will look through the heavy area to find space.
        public List<StorageSpace> SetLightItems()
        {
            int CurrentStorageSpace = 0;
            var totalStorageSpace = new List<StorageSpace>();

            foreach (Aisle p in aisleList.Where(p => !p.IsHeavy))
            {
                totalStorageSpace.AddRange(p.StorageSpaceList);
            }

            // Checks if we need to look in the heavy aisles to find space.
            if (lightItemList.Count > totalStorageSpace.Count)
            {
                // Checks in there is enough space in the heavy aisles. If the expression is true, the warehouse is too small.
                if (lightItemList.Count > totalStorageSpace.Count + leftOverSpaceHeavy)
                    throw new ArgumentOutOfRangeException("Too many Items. Warehouse not big enough.");

                for (int i = 0; i < heavyAislesNumber; i++)
                {
                    foreach (StorageSpace p in aisleList[i].StorageSpaceList.Where(p => p.isEmpty))
                    {
                        //If we find an empty space in heavyArea we set it to a high number 
                        p.distance = 1000000;
                        totalStorageSpace.Add(p);
                    }
                }
            }

            //Sorts the spaces in the warehouse after distance (low to high)
            totalStorageSpace = (from p in totalStorageSpace
                orderby p.distance
                select p).ToList();

            //places items from lightItem list, to the totalStorageSpace list.
            foreach (Item p in lightItemList)
            {
                totalStorageSpace[CurrentStorageSpace].SetItem(p);
                CurrentStorageSpace++;
            }

            //Sets the acutal storagespacelists equal to the storage spaces in the totalStorageSpace list.
            foreach (StorageSpace p in totalStorageSpace)
            {
                //-1 is used so that we are talking about the right aisle.
                aisleList[p.adress.Aisle - 1].StorageSpaceList[p.ID - 1].item = p.item;
                aisleList[p.adress.Aisle - 1].StorageSpaceList[p.ID - 1].isEmpty = false;
            }

            return totalStorageSpace;
        }

        //Counts how many items are heavy and defines what part of the warehouse is heavy area.
        private void SetHeavyArea(int spaces)
        {
            int count = heavyItemList.Count;
            int numberOfAisles = 1;
            bool enoughSpaceFound = false;

            //As long as the amount of heavy items is not equal to 0 and not enough space have been found.
            while (count != 0 && !enoughSpaceFound)
            {
                //If the amount of heavy items is <= the capacity (the total amount of space in the aisle) * numberOfAisles.
                //So if the amount of heavy items is lower than the capacity of the first aisle, 
                //then we inform that enough space have been found by setting enough space=true.
                if (numberOfAisles > aisleList.Count)
                    throw new ArgumentOutOfRangeException("Too many heavy items, out of aisles.");

                if (count <= aisleList[0].StorageSpaceList.Capacity*numberOfAisles)
                {
                    for (int k = 0; k < numberOfAisles; k++)
                        aisleList[k].IsHeavy = true;

                    enoughSpaceFound = true;
                }
                else
                    numberOfAisles++;
            }
            // (spaces * 2 * numberOfAisles) is the total capacity in the aisles that is marked for heavy items.
            // (spaces * 2 * numberOfAisles) - heavyItemList.Count is the number of spaces in the total capacity, that is not yet taken.
            leftOverSpaceHeavy = count != 0 ? (spaces*2*numberOfAisles) - heavyItemList.Count : 0;
            heavyAislesNumber = count != 0 ? numberOfAisles : 0;
        }

        //Sorts the heavy and light items into most popular in descending order (biggest to lowest).

        private void SortByPopularity()
        {
            //We cast it to a ToList instead of IEnumerable because the heavy items are in a list and we cant put an IEnumerable in a list.
            heavyItemList = (from p in heavyItemList
                orderby p.Popularity descending
                select p).ToList();

            lightItemList = (from p in lightItemList
                orderby p.Popularity descending
                select p).ToList();

            heavyItemList.ForEach(i => i.Popularity = 0);
            lightItemList.ForEach(i => i.Popularity = 0);
        }


        //Places the heavy items in the heavyArea
        public void SetHeavyItems(int spaces)
        {
            int currentAisle = 0;
            int currentStorageSpace = 0;
            //Marks the area that is used for heavy items
            SetHeavyArea(spaces);

            foreach (Item heavyItem in heavyItemList)
            {
                //The item in the storageList is equal to the first item in the heavyItemList.
                aisleList[currentAisle].StorageSpaceList[currentStorageSpace].SetItem(heavyItem);
                aisleList[currentAisle].StorageSpaceList[currentStorageSpace].isEmpty = false;
                currentStorageSpace++;

                //When the aisle is full we start over with the next aisle.
                if (currentStorageSpace != aisleList[currentAisle].capacity) continue;
                currentAisle++;
                currentStorageSpace = 0;
            }
        }

        //Clears the connection between item and storagespace.
        public void Clear()
        {
            foreach (StorageSpace b in aisleList.SelectMany(a => a.StorageSpaceList))
            {
                b.item = null;
            }
        }
    }
}