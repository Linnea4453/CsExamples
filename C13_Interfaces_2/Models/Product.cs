using System;
using System.Collections.Generic;
using System.Text;
using C13_Interfaces_2.Interfaces;

namespace C13_Interfaces_2.Models
{
    class Product : IShoppingItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool OrderCompleted { get; private set; }

        public void ShippingItem()
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Varan { Name } har skickats iväg.");
                OrderCompleted = true;
            
            
            }
        
        
        }
    }
}
