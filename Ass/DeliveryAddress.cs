using System;
using System.Collections.Generic;
using System.Text;

namespace Ass
{
    internal struct DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city , string street , int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public override string ToString()
        {
            return $"{BuildingNumber} {Street} ,{City}";
        }
    }
}
