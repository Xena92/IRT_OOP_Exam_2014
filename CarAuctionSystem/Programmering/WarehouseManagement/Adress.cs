using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarehouseManagement
{
    /// <summary>
    /// Adress of items within the warehouse
    /// </summary>
    public class Adress
    {
        /// <summary>
        /// Aisle number of the items placement in the warehouse
        /// </summary>
        public int Aisle;
        /// <summary>
        /// The shelf number of the items placement within the warehouse
        /// </summary>
        public int Shelf;

        public Adress(int storageSpace, int aisle)
        {
            Aisle = aisle;
            Shelf = storageSpace;
        }

        /// <summary>
        /// Formats the adress to a readable string
        /// </summary>
        /// <returns>String of the format: {aisle}.{shelf}</returns>
        public override string ToString()
        {
            return string.Format("{0:D2}.{1:D2}", Aisle, Shelf);
        }

        public static bool operator ==(Adress adress1, Adress adress2)
        {
            if (ReferenceEquals(adress1, null) || ReferenceEquals(adress2, null))
                return false;

            return adress1.Aisle == adress2.Aisle && adress1.Shelf == adress2.Shelf;
        }

        public static bool operator !=(Adress adress1, Adress adress2)
        {
            return !(adress1 == adress2);
        }
    }
}
