using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class TrafficLight : ITrafficLight
    {
        public Guid Id { get; set; }
        public string Location { get; set; }

        public void ChangeLight()
        {
            throw new NotImplementedException();
        }

        public void WarningLight()
        {
            throw new NotImplementedException();
        }
    }
}
