using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class License : ILicense
    {
        public string Name { get; set; }


        public int NumberOfLicenses { get; set; } = 1;


        public string Id { get; set; }
        public string Description { get; set; }

        public bool OrderCompleted { get; private set; }

        public void ShippingItem()
        {
            Console.WriteLine($"Licensen för {Name} har skickats till e-postadressen.");
        }
    }
}