using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingBiteFinalProject
{
    internal class OrderQueue
    {
        public static List<KitchenOrders> PendingOrders = new List<KitchenOrders>();
        public static List<KitchenOrders> PreparingOrders = new List<KitchenOrders>();
        public static List<KitchenOrders> ReadyOrders = new List<KitchenOrders>();
    }
}
