using System.Collections.Generic;

namespace COMP3602Assign04
{
    class ItemList : List<Item>
    {
        public decimal TotalPrice
        {
            get
            {
                decimal price = 0m;
                foreach (Item item in this)
                {
                    price += item.Price;
                }
                return price;
            }
        }
    }
}
