using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WingBiteFinalProject
{
    public partial class Show_Low_Stock_report : Form
    {
        public Show_Low_Stock_report()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory_Tracking inventory = new Inventory_Tracking();
            inventory.Show();
            this.Hide();
        }

        private void Show_Low_Stock_report_Load(object sender, EventArgs e)
        {

        }
    }
}
