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
    public partial class Sales_Report_Details : Form
    {

        string connString = "Server=ANGELO\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private readonly Form _previousForm;
        private string _reportType;
        private DateTime _from;
        private DateTime _to;

        public Sales_Report_Details(Form previousForm, string reportType, DateTime from, DateTime to)
        {
            InitializeComponent();
            _previousForm = previousForm;
            _reportType = reportType;
            _from = from;
            _to = to;
            LoadReportDetails();
        }

        private void LoadReportDetails()
        {
            lblReportTitle.Text = _reportType;
            lblDateResult.Text = _from.ToString("MM/dd/yyyy") + " - " + _to.ToString("MM/dd/yyyy");

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string summaryQuery = @"SELECT 
                                            ISNULL(SUM(s.totalPrice), 0) AS TotalSales,
                                            COUNT(DISTINCT s.OrderID) AS TotalTransactions,
                                            ISNULL(AVG(s.totalPrice), 0) AS AverageSales
                                            FROM salesTBL s
                                            WHERE s.SaleDate BETWEEN @from AND @to";

                    SqlCommand summaryCmd = new SqlCommand(summaryQuery, conn);
                    summaryCmd.Parameters.AddWithValue("@from", _from);
                    summaryCmd.Parameters.AddWithValue("@to", _to);
                    SqlDataReader reader = summaryCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblTotalSalesResult.Text = "₱" + Convert.ToDecimal(reader["TotalSales"]).ToString("N2");
                        lblTransactionResult.Text = reader["TotalTransactions"].ToString();
                        lblAverageSalesResult.Text = "₱" + Convert.ToDecimal(reader["AverageSales"]).ToString("N2");
                    }
                    reader.Close();

                    string detailQuery = "";

                    switch (_reportType)
                    {
                        case "Daily Summary":
                            detailQuery = @"SELECT CAST(s.SaleDate AS DATE) AS Date,
                                            p.productName AS Product,
                                            s.quantity AS Quantity,
                                            s.unitPrice AS UnitPrice,
                                            s.totalPrice AS Total,
                                            o.orderType AS OrderType
                                            FROM salesTBL s
                                            JOIN productsTBL p ON s.prod_ID = p.productID
                                            JOIN ordersTBL o ON s.OrderID = o.OrderID
                                            WHERE s.SaleDate BETWEEN @from AND @to
                                            ORDER BY s.SaleDate DESC";
                            break;

                        case "Weekly Summary":
                            detailQuery = @"SELECT DATEPART(YEAR, s.SaleDate) AS Year,
                                            DATEPART(WEEK, s.SaleDate) AS Week,
                                            p.productName AS Product,
                                            SUM(s.quantity) AS TotalQuantity,
                                            SUM(s.totalPrice) AS TotalSales
                                            FROM salesTBL s
                                            JOIN productsTBL p ON s.prod_ID = p.productID
                                            WHERE s.SaleDate BETWEEN @from AND @to
                                            GROUP BY DATEPART(YEAR, s.SaleDate), DATEPART(WEEK, s.SaleDate), p.productName
                                            ORDER BY Year DESC, Week DESC";
                            break;

                        case "Monthly Summary":
                            detailQuery = @"SELECT DATEPART(YEAR, s.SaleDate) AS Year,
                                            DATEPART(MONTH, s.SaleDate) AS Month,
                                            p.productName AS Product,
                                            SUM(s.quantity) AS TotalQuantity,
                                            SUM(s.totalPrice) AS TotalSales
                                            FROM salesTBL s
                                            JOIN productsTBL p ON s.prod_ID = p.productID
                                            WHERE s.SaleDate BETWEEN @from AND @to
                                            GROUP BY DATEPART(YEAR, s.SaleDate), DATEPART(MONTH, s.SaleDate), p.productName
                                            ORDER BY Year DESC, Month DESC";
                            break;

                        case "Transaction History":
                            detailQuery = @"SELECT t.RecordID AS ID,
                                            t.OrderID,
                                            o.TimePlaced,
                                            o.orderType AS OrderType,
                                            t.PaymentMethod,
                                            t.totalAmount AS TotalAmount,
                                            t.change AS Change
                                            FROM transactionTBL t
                                            JOIN ordersTBL o ON t.OrderID = o.OrderID
                                            WHERE o.TimePlaced BETWEEN @from AND @to
                                            ORDER BY o.TimePlaced DESC";
                            break;

                        case "Top Selling Products":
                            detailQuery = @"SELECT p.productName AS Product,
                                            SUM(s.quantity) AS TotalQuantitySold,
                                            SUM(s.totalPrice) AS TotalRevenue,
                                            AVG(s.unitPrice) AS AveragePrice
                                            FROM salesTBL s
                                            JOIN productsTBL p ON s.prod_ID = p.productID
                                            WHERE s.SaleDate BETWEEN @from AND @to
                                            GROUP BY p.productName
                                            ORDER BY TotalQuantitySold DESC";
                            break;

                        default:
                            MessageBox.Show("Unknown report type: " + _reportType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(detailQuery, conn);
                    da.SelectCommand.Parameters.AddWithValue("@from", _from);
                    da.SelectCommand.Parameters.AddWithValue("@to", _to);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDetailData.DataSource = dt;
                    dgvDetailData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDetailData.RowHeadersVisible = false;
                    dgvDetailData.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Close();
        }

        private void dgvDetailData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Report_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
