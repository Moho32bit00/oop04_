using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public struct DeliveryAddress
    {
        public string City { set; get; }
        public string Street { set; get; }
        public int BuildingNumber { set; get; }

        public DeliveryAddress(string city, string Street, int buildingNumber)
        {
            this.City = city;
            this.Street = Street;
            this.BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"City : {City}\nStreet : {Street}\nBuilding Number : {BuildingNumber}\n";
        }

    }
}
