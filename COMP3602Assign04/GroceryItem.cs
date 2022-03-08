using System;

namespace COMP3602Assign04
{
    class GroceryItem : Item
    {
        public readonly DateTime expirationDate;
        public GroceryItem(string description, string sku, string price, string expirationDate)
            : base(description, sku, price)
        {
            DateTime.TryParse(expirationDate, out this.expirationDate);
        }
        public DateTime ExpirationDate { get { return expirationDate; } }
    }
}
