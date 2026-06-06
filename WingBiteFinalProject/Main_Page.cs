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

        private void btnUser_Click(object sender, EventArgs e)
        {
            User_Management user = new User_Management();
            user.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Menu_or_Product_Module menu = new Menu_or_Product_Module();
            menu.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory_Tracking inventory = new Inventory_Tracking();
            inventory.Show();
            this.Hide();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            Kitchen_Queue_Display kitchen = new Kitchen_Queue_Display();
            kitchen.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports_Form report = new Reports_Form();
            report.Show();
            this.Hide();
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            if (!LoginForm.CurrentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
              
                btnUser.Visible = false;

              
                btnReports.Visible = false;
            }
        
    }
    }
}
