using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public  class DeliveryReport 
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GettrackingStatus());
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
    }
}
