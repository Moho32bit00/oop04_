using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extrafee;
        public decimal ExtraFee
        {
            get { return extrafee; }
            set
            {
                if (ExtraFee >= 0)
                {
                    extrafee = value;
                }
            }
        }
        public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + ExtraFee; } }

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
            ExtraFee : {ExtraFee}
            Estimated Cost : {EstimatedCost}");

        }

        public ExpressShipment() { }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal ExtraFee, string trackingStatus) : base(trackingCode, description, weight, deliveryFee, destination , trackingStatus)
        {
            Destination = destination;
            this.ExtraFee = ExtraFee;
        }

        public string GettrackingStatus()
        {
            return TrackingStatus;
        }

        public decimal CalculateInsurance()
        {
            Console.WriteLine("Calculated Insurance ");
            return 0.12m * EstimatedCost;
        }

    }
}
