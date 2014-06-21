using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class StorageSpace
    {
        public int ID;
        public bool isEmpty;
        //Opfølg ved at få lavet adress klassen. Skal adress være aisle+storagespace dvs 0101 for første række første hylde
        public Adress adress;
        public Coords coords;

        public Item item;
        public double distance;

        public StorageSpace(int id, int aisleId, Coords coords)
        {
            this.isEmpty = true;
            ID = id;
            adress = new Adress(id, aisleId);
            this.coords = coords;
        }

        public void SetItem(Item item)
        {
            this.item = item;
            item.Adress = adress;
        }
    }
}
