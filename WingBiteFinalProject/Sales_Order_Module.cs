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
    public partial class Sales_Order_Module : Form
    {
        public Sales_Order_Module()
        {
            InitializeComponent();
        }

        private void Sales_Order_Module_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();
        }

        private void rbWings_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void rbRicePlatter_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void rbDrinks_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
        }
        
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
        
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
        }
    }
}
