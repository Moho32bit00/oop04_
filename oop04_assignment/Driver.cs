using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public class Driver
    {
        public Driver() { }
        public Driver(int driverId, string fullName, double phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public int DriverId { get; set; }
        public string FullName { get; set; }
        public double PhoneNumber { get; set; }


    }
}
