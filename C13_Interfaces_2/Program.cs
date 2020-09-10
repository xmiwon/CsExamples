using C13_Interfaces_2.Helpers;
using C13_Interfaces_2.Models;
using System;

namespace C13_Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = SampleData.CartSampleItems();

            foreach (var item in cart)
            {
                item.ShippingItem();
                // is - är av typen ILicense license?
                if (item is ILicense license)
                    Console.WriteLine($"- Du har { license.NumberOfLicenses } st licenser att använda.");
            }

        }
    }
}