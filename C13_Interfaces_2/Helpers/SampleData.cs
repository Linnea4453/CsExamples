using System;
using System.Collections.Generic;
using System.Text;
using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleIteams()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "2233", Name = "Apple Airpods", Description = "Airpods med Etui" });
            output.Add(new Product { Id = "9955", Name = "Sodastream", Description = "Sodastream med kolsyrepatron" });
            output.Add(new Product { Id = "3366", Name = "Day vattenflaska", Description = "Rosa 500ml" });


            output.Add(new License { Id = "4546464", Name = "Windows 10 Pro", Description = "Program microsoft Windows 10 PRO", NumberOfLicense = 1 });
            output.Add(new License { Id = "895689", Name = "Microsoft Windows Standard ", Description = "Windows Server Standard", NumberOfLicense = 5 });
           
            return output;

            



        }

    }
}
