using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarehouseManagement
{

    public class Item
    {
        public int Amount, Popularity, Id;
        public string Name;
        public double Weight, Value;
        public Adress Adress;
        public bool listed;
        public double ResultWV
        {
            get { return Weight - Value; }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:D4}", Adress, Id);
        }

        public string NewToString()
        {
            return string.Format("{0}:{1:D4} {2,20} {3}", Adress, Id, Name, Weight);
        }
    }
}