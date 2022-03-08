using System;

namespace COMP3602Assign04
{
    class ConsolePrinter
    {
        public static void PrintHeaderBeforeSort() { Console.WriteLine("Natural Order: "); }
        public static void PrintHeaderAfterSort() { Console.WriteLine("Sorted Order: [Price Descending]"); }
        public static void PrintList(ItemList items)
        {
            string dashLine = new string('-', 69);
            string dateFormat = "ddd MMM dd, yyyy";

            Console.WriteLine($"{"Item",-41}{"Price",10}  {"Expires",-15}");
            Console.WriteLine(dashLine);

            foreach (Item item in items)
            {
                if (item is GroceryItem)
                {
                    GroceryItem groceryItem = item as GroceryItem;
                    if (groceryItem.ExpirationDate == DateTime.MinValue)
                    {
                        Console.WriteLine($"{groceryItem.Description,-41}{groceryItem.Price,10:N2}  {"<Never>",-15}");//<never> means a GroceryItem object does not expire
                    }
                    else
                    {
                        Console.WriteLine($"{groceryItem.Description,-41}{groceryItem.Price,10:N2}  {groceryItem.ExpirationDate.ToString(dateFormat),-15}");
                    }
                }
                else if (item is ApplicationItem)
                {
                    ApplicationItem applicationItem = item as ApplicationItem;
                    Console.WriteLine($"{applicationItem.Description,-41}{applicationItem.Price,10:N2}  {"<N/A>",-15}");//expiration date is not applicable for an ApplicationItem object
                }
            }
            Console.WriteLine(dashLine);
            Console.WriteLine($"{"Total",-41}{items.TotalPrice,10:N2}  {"",-15}\n\n\n");
        }
    }
}
