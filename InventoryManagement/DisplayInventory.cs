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
    }
}
