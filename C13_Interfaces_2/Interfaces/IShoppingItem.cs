using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Interfaces
{
    public interface IShoppingItem
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }


        bool OrderCompleted { get; }
        void ShippingItem();
    }
}