using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class BandSaw : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Band Saw has started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Band Saw has stopped.");
            return true;
        }
    }
}