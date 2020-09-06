using System;
using C13_Interfaces_2.Helpers;
using C13_Interfaces_2.Models;

namespace C13_Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = SampleData.CartSampleIteams();


            foreach (var item in cart)

            {
                
                item.ShippingItem();
                if (item is ILicense license)
                    Console.WriteLine($"- Du har { license.NumberOfLicense } st licenser att använda.");
            }

               
            
                

        }
    }
}
