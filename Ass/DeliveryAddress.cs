using System;
using System.Collections.Generic;
using System.Text;

namespace Ass
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;

        public override string ToString()
        {
            return $"City is {City} , Street is {Street}";
        }
    }
}
