using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class DisplayInventory
    {   //Using Polymorphism 

        //Display rice list
        public void ShowInventory(List<InventoryItems.Rice> ricelist)
        {
            foreach (InventoryItems.Rice item in ricelist)
            {
                Console.WriteLine("Name: {0}\nWeight: {1}Price: {2}", item.name,item.price,item.weight);
            }
        }
        //Display wheat list
        public void ShowInventory(List<InventoryItems.Wheats> wheatlist)
        {
            foreach (InventoryItems.Wheats item in wheatlist)
            {
                Console.WriteLine("Name: {0}\nWeight: {1}Price: {2}", item.name, item.price, item.weight);
            }
        }
        //Display pulses list
        public void ShowInventory(List<InventoryItems.Pulses> pulseslist)
        {
            foreach (InventoryItems.Pulses item in pulseslist)
            {
                Console.WriteLine("Name: {0}\nWeight: {1}Price: {2}", item.name, item.price, item.weight);
            }
        }


        public void DeleteInventory(List<InventoryItems.Rice> riceList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            riceList.Remove(riceList.Find(result => result.name.Equals(temp)));
        }
        //Delete Pulse Type
        public void DeleteInventory(List<InventoryItems.Pulses> pulseList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            pulseList.Remove(pulseList.Find(result => result.name.Equals(temp)));
        }
        //Delete Wheat Type
        public void DeleteInventory(List<InventoryItems.Wheats> wheatList)
        {

            Console.WriteLine("Enter rice name to be deleted");
            string temp = Console.ReadLine();
            wheatList.Remove(wheatList.Find(result => result.name.Equals(temp)));
        }



        public void AddInventory(List<InventoryItems.Rice> ricelist)
        {
            InventoryItems.Rice rice = new InventoryItems.Rice();
            Console.WriteLine("Enter the rice name: ");
            rice.name = Console.ReadLine();
            Console.WriteLine("Enter the rice price: ");
            rice.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rice weight (kg): ");
            rice.weight = Convert.ToInt32(Console.ReadLine());
           
            ricelist.Add(rice);

        }
        //Add new wheat type
        public void AddInventory(List<InventoryItems.Wheats> wheatList)
        {
            InventoryItems.Wheats wheat = new InventoryItems.Wheats();
            Console.WriteLine("Enter the wheat name: ");
            wheat.name = Console.ReadLine();
            Console.WriteLine("Enter the wheat price: ");
            wheat.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the wheat weight(in kg): ");
            wheat.weight = Convert.ToInt32(Console.ReadLine());
          
            wheatList.Add(wheat);

        }
        //Add new Pulse Type
        public void AddInventory(List<InventoryItems.Pulses> pulseList)
        {
            InventoryItems.Pulses pulse = new InventoryItems.Pulses();
            Console.WriteLine("Enter the pulse name: ");
            pulse.name = Console.ReadLine();
            Console.WriteLine("Enter the pulse price: ");
            pulse.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pulse weight(in kg): ");
            pulse.weight = Convert.ToInt32(Console.ReadLine());
    
            pulseList.Add(pulse);

        }
    }

}

