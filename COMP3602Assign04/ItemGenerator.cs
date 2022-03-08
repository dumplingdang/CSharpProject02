using System;
using System.IO;
namespace COMP3602Assign04
{
    class ItemGenerator
    {
        private string lineData;
        private StreamReader streamReader;
        ItemList items = new ItemList();
        public ItemGenerator(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("File not found");
            }
            else
            {
                try
                {
                    using (streamReader = new StreamReader(path))
                    {
                        while ((lineData = streamReader.ReadLine()) != null)
                        {
                            string[] itemStructure = lineData.Split(',');//put each text line into a string array
                            if (itemStructure.Length == 3)
                            {
                                items.Add(new GroceryItem(itemStructure[0], itemStructure[1], itemStructure[2], null));//generate a GroceryItem object without expiration date missing
                            }
                            else if (Enum.TryParse(itemStructure[3], out Type applicationType) == true)
                            {
                                items.Add(new ApplicationItem(itemStructure[0], itemStructure[1], itemStructure[2], itemStructure[3]));//generate an ApplicationItem object is there is an application type in a text line
                            }
                            else
                            {
                                items.Add(new GroceryItem(itemStructure[0], itemStructure[1], itemStructure[2], itemStructure[3]));//generate a GroceryItem object with an expiration date
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        public ItemList Items { get { return items; } }

    }
}
