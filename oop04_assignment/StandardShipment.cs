using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace oop04_assignment
{
   public  class StandardShipment : Shipment, ITrackable , IInsurable
    {
        public StandardShipment() { }
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }
        public override decimal EstimatedCost
        { get { return deliveryFee; } }
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine($@"Tracking Code: {TrackingCode}
            Description: {Description}
            Destination :
            City : {Destination.City}
            Street : {Destination.Street}
            Building Number : {Destination.BuildingNumber}
            Weight: {Weight} kg
            Delivery Fee: {DeliveryFee}
            Estimated Cost : {EstimatedCost}
            Destination: {Destination}");
        }

        public string GettrackingStatus()
        {
            return "standard delivery ready";           
        }

        public decimal CalculateInsurance()
        {
            Console.WriteLine("Calculated Insurance ");
            return 0.05m * EstimatedCost;
        }
    }
}
