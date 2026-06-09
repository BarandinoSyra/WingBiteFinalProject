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
    public partial class Main_Page : Form
    {

        public Main_Page() 
        {
            InitializeComponent();
        }
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

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
            string query = "SELECT COUNT(*) From inventoryTBL Where currentStock <= 20";
           using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int lowStockCount = (int)cmd.ExecuteScalar();
                    lblOrdersValue.Text = lowStockCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching low stock count: " + ex.Message);
                }

                
            }
      

        }
        private void LoadDailySummarySales()
        {
            string query = "SELECT SUM(totalPrice) FROM salesTBL WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        lblSalesPrice.Text = "₱" + Convert.ToDouble(result).ToString("N2");
                    }
                    else
                    {
                        lblSalesPrice.Text = "₱0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void Main_Page_Load(object sender, EventArgs e)
        {
            string ShowPendingOrdersQuery = @"SELECT o.OrderID, o.TimePlaced, o.orderType, o.orderstatus
                                  FROM ordersTBL o
                                  WHERE o.orderstatus = 'Pending'
                                  ORDER BY o.OrderID DESC";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(ShowPendingOrdersQuery, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRecentOrders.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching pending orders: " + ex.Message);
                }
            }
            if (!LoginForm.CurrentUserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {

                btnUser.Visible = false;


                btnReports.Visible = false;
            }
            LoadDailySummarySales();

        }
       

        private void dgvRecentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Show_Low_Stock_report showLowStock = new Show_Low_Stock_report();
           showLowStock.Show();
            this.Hide();


        }
    }
    }

