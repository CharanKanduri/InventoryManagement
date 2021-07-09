using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class InventoryManagment
    {
        internal interface IInventoryManager
        {
            //Display methods
            void ShowInventory(List<InventoryItems.Rice> ricelist);
            void ShowInventory(List<InventoryItems.Wheats> wheatList);
            void ShowInventory(List<InventoryItems.Pulses> pulseList);
            //Add Methods
            public void AddInventory(List<InventoryItems.Wheats> wheatList);
            public void AddInventory(List<InventoryItems.Pulses> pulseList);
            public void AddInventory(List<InventoryItems.Rice> ricelist);
            //Delete Methods
            public void DeleteInventory(List<InventoryItems.Rice> riceList);
            public void DeleteInventory(List<InventoryItems.Pulses> pulseList);
            public void DeleteInventory(List<InventoryItems.Wheats> wheatList);
        }
    }
}
