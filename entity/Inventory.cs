using System.Collections.Generic;
using item;

namespace entity
{
    public class Inventory : List<Item>
    {
        public Inventory()
        { 
            // default
            Capacity = 10;
        }

        public Inventory Get()
        {
            return this;
        }
    }
}