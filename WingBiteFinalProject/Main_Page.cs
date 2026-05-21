using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingBiteFinalProject
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales_Order_Module salesOrder = new Sales_Order_Module();
            salesOrder.Show();
            this.Hide();
        }
    }
}
