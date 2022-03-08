//Pros of the application design
//1. Flexible to add other objects inherited from Item class
//2. Save time to declare a derived class of which common properties have been declared in the base class and can be used in the derived class
//
//Cons of the application design
//1. SKU is missing. It is a unique identifier of an item which should be written in the console
//2. There are many null or invalid inputs in the Expires field which is not good for data management

using System;
namespace COMP3602Assign04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP3602 - Assignment 04 - A01199432";
            string path = @"..\..\items.csv";
            ItemGenerator itemGenerator = new ItemGenerator(path);
            ItemList items = itemGenerator.Items;
            ConsolePrinter.PrintHeaderBeforeSort();
            ConsolePrinter.PrintList(items);
            items.Sort();
            ConsolePrinter.PrintHeaderAfterSort();
            ConsolePrinter.PrintList(items);
        }
    }
}
