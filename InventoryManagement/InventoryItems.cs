using System;
using System.Collections.Generic;


namespace InventoryManagement
{
    class InventoryItems
    {       //Created class inventory items
        public class Rice
        { 
            public string name { get; set; }
            public float weight { get; set; }
            public int price { get; set; }
        }

        public class Pulses
        {
            public string name { get; set; }
            public float weight { get; set; }
            public int price { get; set; }
        }

        
        public class Wheats
        {
            public string name { get; set; }
            public float weight { get; set; }
            public int price { get; set; }
        }


        //creating list for each inventory item class

        public List<Rice> RiceList { get; set; }
        public List<Pulses> PulsesList { get; set; }
        public List<Wheats> WheatList { get; set; }



    }
}
