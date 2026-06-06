using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingBiteFinalProject
{
    public class KitchenOrders
    {
        public string OrderNumber { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public string OrderType { get; set; }

        public string OrderTime
        {
            get; set;
        }
    }
}