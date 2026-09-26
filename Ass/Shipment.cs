using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ass
{
    internal struct Shipment
    {
        public string Description { get; set; }
        private double Weight;
        public decimal DeliveryFee { get; set; }


        public double weight 
        {
            get
            {
                return Weight;
            }
            set
            {
                Weight = value > 0  ? value : 0; // Validation
            }
        }
    }
}
