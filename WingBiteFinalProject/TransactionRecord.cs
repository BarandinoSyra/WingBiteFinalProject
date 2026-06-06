using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingBiteFinalProject
{
    internal class TransactionRecord
    {
        public string OrderNumber { get; set; }

        public decimal TotalAmount { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Change { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
