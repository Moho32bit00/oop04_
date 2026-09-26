using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private decimal customsFee;
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (CustomsFee >= 0)
                {
                    customsFee = value;
                }
            }

        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($@"Tracking Code: {TrackingCode}
        Description: {Description}
        Destination :
        Destination Country : {Destination.DestinationCountry}
        City : {Destination.City}
        Street : {Destination.Street}
        Building Number : {Destination.BuildingNumber}
        Weight: {Weight} kg
        Delivery Fee: {DeliveryFee}
        CustomsFee : {CustomsFee}
        Estimated Cost : {EstimatedCost}");
        }

        public virtual void GenerateCustomsReport() { }
        public InternationalShipment() { }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal CustomsFee , string trackingStatus) : base(trackingCode, description, weight, deliveryFee, destination , trackingStatus)
        {
            this.CustomsFee = CustomsFee;
        }

        public string GettrackingStatus()
        {
            return TrackingStatus;
        }

        public decimal CalculateInsurance()
        {
            Console.WriteLine("Calculated Insurance ");
            return 0.08m * EstimatedCost;
        }
    }
}
