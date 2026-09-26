using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public class DeliveryCenter
    {

        private Shipment[] shipment;
        public string CenterName { get; set; }
        public DeliveryCenter() { this.shipment = new Shipment[20]; }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                {
                    return shipment[index];
                }
                else { return default; ; }
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                {
                    shipment[index] = value;
                }
            }
        }

        public Shipment this[string TrackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i].TrackingCode == TrackingCode)
                    {
                        return shipment[i];
                    }

                }
                return default;
            }
        }

        public Driver Driver { set; get; }

        public bool AddShipment(Shipment s_shipment)
        {
            if (shipment == null) shipment = new Shipment[20];

            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i] == null)
                {
                   shipment[i] = s_shipment;
                    return true;
                }

            }
            return false;
        }

        public bool RemoveShipment(string tracking_code)
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i].TrackingCode == tracking_code)
                {
                    for (int j = i; j < shipment.Length - 1; j++)
                    {
                        shipment[j] = shipment[j + 1];
                    }
                    shipment[shipment.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
                    Console.WriteLine("=================================================All Shipments :");
            foreach (var item in shipment)
            {
                if (item != null)
                {
                    item.PrintShipment();
                    Console.WriteLine();
                    Console.WriteLine("=================================================");
                }
            }
        }
        public void PrintAllTrackingStatues()
        {
            int counter = 0; 
                Console.WriteLine("=================================================All tracking status");
            foreach (ITrackable t in shipment)
            { if (t != null)
                {
                    Console.WriteLine($"Shipment {shipment[counter].TrackingCode}  is {t.GettrackingStatus()}.");
                    Console.WriteLine("=================================================");
                    counter++;
                }
                else { return; }
            }
            Console.WriteLine();
        }
        public void PrintAllInsurance()
        {
            int counter = 0;
                Console.WriteLine("=================================================All Insurance");
            foreach (IInsurable i in shipment)
            {
                if (i != null)
                {

                    Console.WriteLine($"{shipment[counter].GetType().Name } Shipment Insurance : {i.CalculateInsurance()}"); ;
                    Console.WriteLine("=================================================");
                    counter++;
                }else { return; }
                Console.WriteLine();
            }
        }
    }
}
