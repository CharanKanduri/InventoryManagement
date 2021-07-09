using System;

using System.IO;
using Newtonsoft.Json;



namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {   //specifying path
            string fileName = @"C:\Users\charan kanduri\source\repos\JasonInventoryManagementDB_BridgeLabz\InventoryManagement\ItemsJson.json";
            InventoryItems items = new InventoryItems();
            items = JsonConvert.DeserializeObject<InventoryItems>(File.ReadAllText(fileName));

            Console.WriteLine("Display inventory Press \n1 - Rice Inventory \n2 - Wheat Inventory \n3 - Pulse Inventory ");

            int chioce=Convert.ToInt32(Console.ReadLine());

            DisplayInventory show = new DisplayInventory();

           


            switch (chioce)
            {
                case 1:
                    show.ShowInventory(items.RiceList);
                    break;
                case 2:
                    show.ShowInventory(items.WheatList);
                    break;
                case 3:
                    show.ShowInventory(items.PulsesList);
                    break;
            }

        }
    }
}
