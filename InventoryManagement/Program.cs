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

            DisplayInventory show = new DisplayInventory();
            DisplayInventory manage = new DisplayInventory();

            Console.WriteLine("select inventory Press \n1 - Rice Inventory \n2 - Wheat Inventory \n3 - Pulse Inventory ");
            int chioce = Convert.ToInt32(Console.ReadLine());


            switch (chioce)
            {
                case 1:
                    //Rice Inventory operations
                    var riceObj = items.RiceList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            manage.AddInventory(riceObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(riceObj);
                            break;
                        case 2:
                            manage.DeleteInventory(riceObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(riceObj);
                            break;
                        case 3:
                            manage.ShowInventory(riceObj);
                            break;
                    }
                     break;
             
                case 2:
                    //
                    var wheatObj = items.RiceList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            manage.AddInventory(wheatObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(wheatObj);
                            break;
                        case 2:
                            manage.DeleteInventory(wheatObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(wheatObj);
                            break;
                        case 3:
                            manage.ShowInventory(wheatObj);
                            break;
                    }
                    break;
                case 3:
                    //

                    var pulseObj = items.RiceList;
                    Console.WriteLine("Enter which operation to perform\n 1-Add to Inventory\n 2-Remove from inventory\n3-Display Inventory");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    switch (num3)
                    {
                        case 1:
                            manage.AddInventory(pulseObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(pulseObj);
                            break;
                        case 2:
                            manage.DeleteInventory(pulseObj);
                            File.WriteAllText(fileName, JsonConvert.SerializeObject(items));
                            manage.ShowInventory(pulseObj);
                            break;
                        case 3:
                            manage.ShowInventory(pulseObj);
                            break;
                    }
                    break;
                    
            }

        }
    }
}
