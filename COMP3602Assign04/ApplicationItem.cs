using System;
namespace COMP3602Assign04
{
    public enum Type
    {
        Washer,
        Dryer,
        Dishwasher,
        Oven,
        Range,
        Refrigerator
    }
    class ApplicationItem : Item
    {
        public Type applicationType;
        public ApplicationItem(string description, string sku, string price, string applicationType)
            : base(description, sku, price)
        {
            Enum.TryParse(applicationType, out this.applicationType);
        }
        public Type ApplicationType { get { return applicationType; } }
    }
}
