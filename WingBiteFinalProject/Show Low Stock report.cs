using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WingBiteFinalProject
{
    public partial class Show_Low_Stock_report : Form
    {
        public Show_Low_Stock_report()
        {
            InitializeComponent();
        }

        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        private void Show_Low_Stock_report_Load(object sender, EventArgs e)
        {
            LoadLowStockData();
        }

        private void LoadLowStockData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT 
                                RIGHT('0000' + CAST(inventoryID AS VARCHAR), 4) AS [Inventory ID], 
                                category AS [Category], 
                                currentStock AS [Current Stock], 
                                CASE 
                                    WHEN currentStock <= 0 THEN 'Out Of Stock'
                                    WHEN currentStock <= 10 THEN 'Low Stock'
                                END AS [Stock Status],
                                FORMAT(lastUpdated, 'MMMM dd, yyyy hh:mm tt') AS [Status Updated Date]
                             FROM inventoryTBL 
                             WHERE currentStock <= 10";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLowStockReport.DataSource = dt;

                    // Optional Formatting
                    if (dgvLowStockReport.Columns["Inventory ID"] != null)
                        dgvLowStockReport.Columns["Inventory ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvLowStockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvLowStockReport.RowHeadersVisible = false;
                    dgvLowStockReport.AllowUserToResizeRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory_Tracking inventory = new Inventory_Tracking();
            inventory.Show();
            this.Hide();
        }

        private void dgvLowStockReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}