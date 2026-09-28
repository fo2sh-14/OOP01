using System;
using System.Collections.Generic;
using System.Text;

namespace Ass
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipment;
        public int Size { get; set; }

        public DeliveryCenter(int size)
        {
            Size = size;
            shipment = new Shipment[size];
        }

        public bool AddShipment(Shipment newShipment)
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i].trackingCode == null)
                {
                    shipment[i] = newShipment;
                    return true;
                }
            }
            return false; 
        }

        #region Indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                    return shipment[index];
                return default;
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                {
                    shipment[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i].trackingCode == trackingCode)
                    {
                        return shipment[i];
                    }
                }
                return default; 
            }
        }
        #endregion
    }
}
