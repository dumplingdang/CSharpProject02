using System;
namespace COMP3602Assign04
{
    abstract class Item : IComparable<Item>
    {
        public string describtion;
        public decimal price;
        public readonly string sku;
        public Item(string description, string sku, string price)
        {
            Description = description;
            decimal.TryParse(price, out this.price);
            this.sku = sku;
        }
        public string Description
        {
            get { return describtion; }
            set { describtion = value; }
        }
        public decimal Price { get { return price; } }
        public string Sku { get { return sku; } }
        public int CompareTo(Item other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return -(Price.CompareTo(other.Price));//sort price in descending order
            }
        }
        public override string ToString()
        {
            return $"{Description} - {Sku} - {Price:N2}";
        }
    }
}
