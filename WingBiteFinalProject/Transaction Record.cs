using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WingBiteFinalProject
{
    // Tiyakin na ang class name ay tugma sa Form partial class architecture mo (Transaction_Record)
    public partial class Transaction_Record : Form
    {
        private readonly string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private readonly string orderNumber;
        private readonly string orderType;
        private readonly decimal totalAmount;
        private readonly decimal finalTotal;
        private readonly string paymentMethod;
        private readonly string change;
        private readonly decimal discountDeduct;

        // Inayos ang constructor signature para maging selyado ang pagtanggap ng 6 na parameters mula sa Payment form
        public Transaction_Record(string orderNumber, string orderType, decimal totalAmount, decimal finalTotal, string paymentMethod, string change)
        {
            InitializeComponent();

            this.orderNumber = orderNumber;
            this.orderType = orderType;
            this.totalAmount = totalAmount;
            this.finalTotal = finalTotal;
            this.paymentMethod = paymentMethod;
            this.change = change;

            // Awtomatikong kukuwentahin ang ibinawas na diskwento
            this.discountDeduct = totalAmount - finalTotal;
        }

        private void Transaction_Record_Load(object sender, EventArgs e)
        {
            DisplayTransactionToLabels();
            SetupAndPopulateGrid();
            SaveTransactionToDatabase();
        }

        private void DisplayTransactionToLabels()
        {
            lblOrderNumResult.Text = orderNumber;
            lblTotalAmountresult.Text = totalAmount.ToString("₱#,##0.00");
            lblPaymentMethodUsed.Text = paymentMethod;
            lblChangeResult.Text = change;
            lblDateTimeResult.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
        }

        private void SetupAndPopulateGrid()
        {
            dgvOrderSummary.AllowUserToAddRows = false;
            dgvOrderSummary.Columns.Clear();

            dgvOrderSummary.Columns.Add("OrderNumber", "Order Number");
            dgvOrderSummary.Columns.Add("OrderType", "Order Type");
            dgvOrderSummary.Columns.Add("TotalAmount", "Total Amount");
            dgvOrderSummary.Columns.Add("DiscountDeduct", "Discount Deduct");
            dgvOrderSummary.Columns.Add("FinalTotal", "Final Total");
            dgvOrderSummary.Columns.Add("PaymentMethod", "Payment Method");

            dgvOrderSummary.Rows.Add(
                orderNumber,
                orderType,
                totalAmount.ToString("₱#,##0.00"),
                discountDeduct.ToString("₱#,##0.00"),
                finalTotal.ToString("₱#,##0.00"),
                paymentMethod
            );
        }

        private void SaveTransactionToDatabase()
        {
            // Inayos ang query para TUGMA LAMANG sa mga totoong kolum ng iyong transactionTBL
            string query = @"INSERT INTO transactionTBL 
                    (OrderID, PaymentMethod, totalAmount, change) 
                    VALUES 
                    (@OrderNumber, @PaymentMethod, @TotalAmount, @Change)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Siguraduhing malinis ang data conversion bago i-save
                        cmd.Parameters.AddWithValue("@OrderNumber", Convert.ToInt32(orderNumber));
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@TotalAmount", finalTotal); // Kung magkano ang totoong ibinayad matapos ang discount

                        // Linisin ang "₱" sign o spaces kung meron man sa string ng change bago i-save bilang decimal/float
                        string cleanChange = change.Replace("₱", "").Trim();
                        decimal changeDecimal = 0;
                        decimal.TryParse(cleanChange, out changeDecimal);

                        cmd.Parameters.AddWithValue("@Change", changeDecimal);

                        cmd.ExecuteNonQuery(); // MAPAYAPA NA ITONG PAPASOK NGAYON!
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save transaction to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Sales_Order_Module salesOrder = new Sales_Order_Module();
            salesOrder.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvOrderSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}