using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007573", Name = "Apple Airpods (2019)", Description = "AirPods med laddningsetui" });
            output.Add(new Product { Id = "1013033", Name = "SodaStream Genesis Megapack Titan/silver", Description = "Sodastream med kolsyrepatron och fyra flaskor" });
            output.Add(new Product { Id = "1005300", Name = "Day Vattenflaska 500ML", Description = "Vattenflaska 500 ml" });

            output.Add(new License { Id = "5010877355", Name = "Microsoft Windows 10 Pro 64-bit Sve OEM", Description = "Program Microsoft Windows 10 Pro 64-bit Sve OEM", NumberOfLicenses = 1 });
            output.Add(new License { Id = "5011108149", Name = "Microsoft Windows Server Standard 2019", Description = "Windows Server Standard 2019 16 Cores Engelsk DVD + 5 CAL Box", NumberOfLicenses = 5 });

            return output;
        }

    }
}