using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ass
{
    internal struct Shipment
    {
        private string TrackingCode;
        private string Description;
        private double Weight;
        private double DeliveryFee;
        public DeliveryAddress Destination {  get; set; }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public string trackingCode
        {
            get { return TrackingCode; }

        }
        public string description
        {
            get { return Description; }
            set
            {
                if (value != null)
                    Description = value;
            }
        }
        public double weight
        {
            get { return Weight; }
            set
            {
                if (value >= 0)
                    Weight = value;
            }
        }
        public double deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {
                if (value >= 0)
                    DeliveryFee = value;
            }
        }

        public double EstimatedCost()
        {
            return DeliveryFee + (Weight * 5);
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
                DeliveryFee = (double)newFee;
        }
        public override string ToString()
        {
            return $"TrackingCode => {TrackingCode} \nDescription => {Description}\nWeight = {Weight}\nDeliveryFee = {DeliveryFee}\nDestination => {Destination}\nEstimatedCost = {EstimatedCost()}";
        }

    }
}
