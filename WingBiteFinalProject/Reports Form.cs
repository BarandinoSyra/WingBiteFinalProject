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
    public partial class Reports_Form : Form
    {
        string connString = "Server=YJAIXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private string currentReportType = "";

        public Reports_Form()
        {
            InitializeComponent();
        }

        // ====================================================================================
        // MGA BUTTONS SA TAAS: Dito agad maglo-load ang data sa tuwing kini-click sila
        // ====================================================================================
        private void btnDaily_Click(object sender, EventArgs e)
        {
            currentReportType = "Daily";
            lblReportTitleResult.Text = "Daily Summary";
            ExecuteReportQuery(); // [BAGO] Agad na kukunin ang data mula sa SSMS
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            currentReportType = "Weekly";
            lblReportTitleResult.Text = "Weekly Summary";
            ExecuteReportQuery(); // [BAGO] Agad na kukunin ang data mula sa SSMS
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            currentReportType = "Monthly";
            lblReportTitleResult.Text = "Monthly Summary";
            ExecuteReportQuery(); // [BAGO] Agad na kukunin ang data mula sa SSMS
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            currentReportType = "Transaction";
            lblReportTitleResult.Text = "Transaction History";
            ExecuteReportQuery(); // [BAGO] Agad na kukunin ang data mula sa SSMS
        }

        private void btnTopSelling_Click(object sender, EventArgs e)
        {
            currentReportType = "TopSelling";
            lblReportTitleResult.Text = "Top Selling Products";
            ExecuteReportQuery(); // [BAGO] Agad na kukunin ang data mula sa SSMS
        }

        // ====================================================================================
        // [BAGO] HELPER METHOD PARA SA PAG-LOAD NG DATA
        // Inihiwalay natin ang query processing para pwedeng tawagin ng kahit anong button sa taas
        // ====================================================================================
        private void ExecuteReportQuery()
        {
            DateTime from = dateTimeFrom.Value.Date;
            DateTime to = dateTimeTo.Value.Date.AddDays(1).AddSeconds(-1);

            if (from > to)
            {
                MessageBox.Show("Date From cannot be later than Date To.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";

            switch (currentReportType)
            {
                case "Daily":
                    query = @"SELECT CAST(s.SaleDate AS DATE) AS Date,
                              COUNT(DISTINCT s.OrderID) AS TotalOrders,
                              SUM(s.totalPrice) AS TotalSales
                              FROM salesTBL s
                              WHERE s.SaleDate BETWEEN @from AND @to
                              GROUP BY CAST(s.SaleDate AS DATE)
                              ORDER BY Date DESC";
                    break;

                case "Weekly":
                    query = @"SELECT DATEPART(YEAR, s.SaleDate) AS Year,
                              DATEPART(WEEK, s.SaleDate) AS WeekNumber,
                              COUNT(DISTINCT s.OrderID) AS TotalOrders,
                              SUM(s.totalPrice) AS TotalSales
                              FROM salesTBL s
                              WHERE s.SaleDate BETWEEN @from AND @to
                              GROUP BY DATEPART(YEAR, s.SaleDate), DATEPART(WEEK, s.SaleDate)
                              ORDER BY Year DESC, WeekNumber DESC";
                    break;

                case "Monthly":
                    query = @"SELECT DATEPART(YEAR, s.SaleDate) AS Year,
                              DATEPART(MONTH, s.SaleDate) AS Month,
                              COUNT(DISTINCT s.OrderID) AS TotalOrders,
                              SUM(s.totalPrice) AS TotalSales
                              FROM salesTBL s
                              WHERE s.SaleDate BETWEEN @from AND @to
                              GROUP BY DATEPART(YEAR, s.SaleDate), DATEPART(MONTH, s.SaleDate)
                              ORDER BY Year DESC, Month DESC";
                    break;

                case "Transaction":
                    query = @"SELECT t.RecordID, t.OrderID, t.PaymentMethod,
                              t.totalAmount, t.change,
                              o.TimePlaced, o.orderType
                              FROM transactionTBL t
                              JOIN ordersTBL o ON t.OrderID = o.OrderID
                              WHERE o.TimePlaced BETWEEN @from AND @to
                              ORDER BY o.TimePlaced DESC";
                    break;

                case "TopSelling":
                    query = @"SELECT p.productName AS Product,
                              SUM(s.quantity) AS TotalQuantitySold,
                              SUM(s.totalPrice) AS TotalRevenue
                              FROM salesTBL s
                              JOIN ProductTBL p ON s.prod_ID = p.productID
                              WHERE s.SaleDate BETWEEN @from AND @to
                              GROUP BY p.productName
                              ORDER BY TotalQuantitySold DESC";
                    break;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@from", from);
                    da.SelectCommand.Parameters.AddWithValue("@to", to);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReportData.DataSource = dt;
                    dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvReportData.RowHeadersVisible = false;
                    dgvReportData.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================================================================
        // VIEW BUTTON: Gagamitin na lamang para lumipat sa susunod na form (Details Window)
        // ====================================================================================
        private void btnView_Click(object sender, EventArgs e)
        {
            if (currentReportType == "")
            {
                MessageBox.Show("Please select a report type first.", "No Report Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime from = dateTimeFrom.Value.Date;
            DateTime to = dateTimeTo.Value.Date.AddDays(1).AddSeconds(-1);
            string reportTitle = lblReportTitleResult.Text;

            // Bubuksan ang bagong window at itatago ang kasalukuyang screen gaya ng orihinal mong nais [3]
            Sales_Report_Details details = new Sales_Report_Details(this, reportTitle, from, to);
            details.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentReportType = "";
            lblReportTitleResult.Text = "Report Title here";
            dgvReportData.DataSource = null;
            dateTimeFrom.Value = DateTime.Now;
            dateTimeTo.Value = DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Close();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {
        }
    }
}
