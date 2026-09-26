using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry
        {
            get { return DestinationCountry; }
            set
            {
                if (DestinationCountry != null || DestinationCountry != "" || DestinationCountry != " ")
                {
                    DestinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
            get { return CustomsFee; }
            set
            {
                if (CustomsFee >= 0)
                {
                    CustomsFee = value;
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
        Destination Country : {DestinationCountry}
        City : {Destination.City}
        Street : {Destination.Street}
        Building Number : {Destination.BuildingNumber}
        Weight: {Weight} kg
        Delivery Fee: {DeliveryFee}
        CustomsFee : {CustomsFee}
        Estimated Cost : {EstimatedCost}
        Destination: {Destination}");
        }

        public virtual void GenerateCustomsReport() { }
        public InternationalShipment() { }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.CustomsFee = CustomsFee;
            this.DestinationCountry = DestinationCountry;
        }

        public string GettrackingStatus()
        {
            return "International Shipment delivery ready ";
        }

        public decimal CalculateInsurance()
        {
            Console.WriteLine("Calculated Insurance ");
            return 0.08m * EstimatedCost;
        }
    }
}
