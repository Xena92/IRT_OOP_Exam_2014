using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WarehouseManagement
{
    public class Knapsack
    {
        public class Bag : IEnumerable<Item> 
        //So we can read through list in items with foreath
        {
            private List<Item> knapsackItems;
            private List<Item> itemsToPickUp;
            public int MaxWeightAllowed = 20;//Max weight allow in the Bag.

            public Bag()
            {
                itemsToPickUp = new List<Item>();//makes list.
                knapsackItems = new List<Item>();//makes list.
            }

            private void AddItem(Item i)
            {
                if (i.listed == false)
                    //Looks for bool in items to see if they haved been picked
                {
                    if ((TotalWeight + i.Weight) < MaxWeightAllowed)
                        //Looks for the Totalweight + the weight of the new item to see if if fits in the Bag.
                    {
                        i.listed = true;//Set Bool true to identify if it haved been picked.
                        itemsToPickUp.Add(i);//Add items to pick up Bag.
                    }
                }

            }

            public void Calculate(List<Item> items)
            {
                foreach (Item i in Sorte(items))//Goes through item in sorte(list)
                {
                    AddItem(i);
                }
            }

            private List<Item> Sorte(List<Item> inputItems)
            {
                List<Item> pickitems = new List<Item>();//Makes new list pickitems
                pickitems.Add(inputItems[0]);//Add item to pickitems from inputitems
                for (int i = 1; i < inputItems.Count; i++)
                {
                    int j = -1;
                    if (!RecursiveF(inputItems, pickitems, i, pickitems.Count - 1, false, ref j))//recursive method calls itself.
                    {
                        pickitems.Add(inputItems[i]);//add the current item.
                    }
                }
                return pickitems;
            }

            bool RecursiveF(List<Item> knapsackItems, List<Item> pickitems, int i, int last, bool dec, ref int toAdd)//recursive method calls itself.
            {
                if (!(last < 0))
                {
                    if (knapsackItems[i].ResultWV < pickitems[last].ResultWV)//Looks for resultWV if it is lower than the last then add the new last.
                    {
                        toAdd = last;//adds the new last to toAdd
                    }
                    return RecursiveF(knapsackItems, pickitems, i, last - 1, true, ref toAdd);
                }
                if (toAdd > -1)
                {
                    pickitems.Insert(toAdd, knapsackItems[i]);//add items to knapsackItems
                    return true;
                }
                return false;
            }            

            public double TotalWeight
            {
                get
                {
                    double sum = 0;
                    foreach (Item i in this)//Looks through all the items in Item
                    {
                        sum += i.Weight;//Adds the weight to the sum
                    }
                    return sum;
                }
            }

            public void AddOrder(Item[] order)
            {
                knapsackItems.AddRange(order.Where(i => !knapsackItems.Contains(i)));
            }

            public List<Item> GetGroup()
            {
                Bag b = new Bag();//Makes Bag.
                b.Calculate(knapsackItems);//Call Calculate for Bag.
                return b.itemsToPickUp;//Returns the Item to pick up.
            }


            #region IEnumerable<Item> Members

            IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
            {
                foreach (Item i in itemsToPickUp)
                    yield return i;
            }

            #endregion

            #region IEnumerable Members

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return itemsToPickUp.GetEnumerator();
            }

            #endregion
        }
        /*class Program
        {
            static void Main(string[] args)
            {
                var orders = OrderGenerator.GetOrders(10);
                var bag = new Bag();
                foreach (var order in orders)
                {
                    bag.AddOrder(order);
                }

                bag.GetGroup();
                Console.ReadKey();
            }
        }*/
    }
}
