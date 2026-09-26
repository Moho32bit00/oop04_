using System;
using System.Collections.Generic;
using System.Text;

namespace oop04_assignment
{
    public abstract class Shipment
    {
        protected string trackingCode;
        private string description;
        private decimal weight;
        protected decimal deliveryFee;
        private string trackingStatus;
        public string TrackingCode => trackingCode;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null && value != "" && value != " ")
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public string TrackingStatus => trackingStatus;
        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public abstract decimal EstimatedCost { get; }

        public DeliveryAddress Destination { get; set; }
        //============
        //constructors
        public Shipment() { }
        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , string trackingStatus)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            Destination = destination;
            this.trackingStatus = trackingStatus;
        }
        //==========

        //methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }


        public abstract void PrintShipment();

        public void weight_update(decimal new_weight)
        {
            if (new_weight > 0)
            {
                weight += new_weight;
            }
        }
        public void weight_update(decimal new_weight, decimal extra_pack_weight)
        {
            if (new_weight > 0 && extra_pack_weight > 0)
            {
                weight += new_weight + extra_pack_weight;
            }
        }


    }
}
