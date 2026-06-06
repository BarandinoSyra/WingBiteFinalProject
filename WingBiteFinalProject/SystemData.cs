using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingBiteFinalProject
{
    internal class SystemData
    {
        public static List<Product> Products = new List<Product>();

        public static List<OrderItem> CurrentOrders = new List<OrderItem>();

        public static List<TransactionRecord> Transactions = new List<TransactionRecord>();

        public static int ProductCounter = 1;

        public static int OrderCounter = 1001;
    }

}
