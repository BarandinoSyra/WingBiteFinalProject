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
    public partial class PaymentForm : Form
    {
        private double originalTotal;
        private double finalTotal;
        private string orderType;
        private int currentOrderID;
        private const double DiscountRate = 0.15;
        private string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public PaymentForm(double subtotal, string typeOfOrder, int orderID)
        {
            InitializeComponent();
            this.originalTotal = subtotal;
            this.finalTotal = subtotal;
            this.orderType = typeOfOrder;
            this.currentOrderID = orderID;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblOrderNumResult.Text = currentOrderID.ToString();
            lblOrderNumResult.Visible = true;
            lblTotalAmountResult.Text = originalTotal.ToString("N2");
            lblFinalTotalResult.Text = originalTotal.ToString("N2");
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Gcash");
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void btnEnter_Click(object sender, EventArgs e) 
        {
            if (!double.TryParse(txtAmountTendered.Text, out double amountTendered) || amountTendered < 0)
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountTendered.Focus();
                return;
            }
            if (amountTendered < finalTotal)
            {
                MessageBox.Show("Insufficient amount tendered! The amount provided is less than the final total.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountTendered.Focus();
                return;
            }
            double change = amountTendered - finalTotal;
            lblChangeResult.Text = change.ToString("N2");
        }

        private void rbDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiscount.Checked)
            {
                double discountDeduct = originalTotal * DiscountRate;
                finalTotal = originalTotal - discountDeduct;
            }
            else
            {
                finalTotal = originalTotal;
            }
            lblFinalTotalResult.Text = finalTotal.ToString("N2");
            lblChangeResult.Text = "Change Result";
        }

        private void btnConfirmPay_Click(object sender, EventArgs e)
        {
            if (lblChangeResult.Text == "Change Result" || string.IsNullOrWhiteSpace(txtAmountTendered.Text))
            {
                MessageBox.Show("Please calculate the change by clicking the 'Enter' button first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string method = cmbPaymentMethod.SelectedItem.ToString();
            string computedChange = lblChangeResult.Text; // Kunin ang calculated change string para ipasa sa kasunod na form

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string updateOrderQuery = "UPDATE ordersTBL SET paymentMethod = @paymentMethod WHERE OrderID = @orderID";
                    using (SqlCommand cmdOrder = new SqlCommand(updateOrderQuery, conn))
                    {
                        cmdOrder.Parameters.AddWithValue("@paymentMethod", method);
                        cmdOrder.Parameters.AddWithValue("@orderID", this.currentOrderID);
                        cmdOrder.ExecuteNonQuery();
                    }

                    string insertKitchenQuery = "INSERT INTO KitchenTBL (KitchenID, OrderID, Dispatch) VALUES (@kitchenID, @orderID, @dispatch)";
                    using (SqlCommand cmdKitchen = new SqlCommand(insertKitchenQuery, conn))
                    {
                        cmdKitchen.Parameters.AddWithValue("@kitchenID", this.currentOrderID);
                        cmdKitchen.Parameters.AddWithValue("@orderID", this.currentOrderID);
                        cmdKitchen.Parameters.AddWithValue("@dispatch", "Pending");
                        cmdKitchen.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment successful via {method}! Order #{this.currentOrderID} has been sent to the Kitchen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Itakda ang resulta bago maglipat ng form
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the transaction:\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Huwag magpatuloy sa Transaction Record kung nagkaroon ng error sa database
                }
            }

            // TUGMAAN NG PARAMETERS:
            // Ang constructor mo ay naghahanap ng: string orderNumber, string orderType, decimal totalAmount, decimal finalTotal, string paymentMethod, string change
            Transaction_Record receipt = new Transaction_Record(
                this.currentOrderID.ToString(), // orderNumber (convert to string kung int ang currentOrderID mo)
                this.orderType,                 // orderType
                Convert.ToDecimal(this.originalTotal), // totalAmount
                Convert.ToDecimal(this.finalTotal),    // finalTotal
                method,                         // paymentMethod
                computedChange                  // change
            );
            receipt.Show(); // Ipakita ang transaction record form
            this.Hide();    // Itago lamang ang kasalukuyang billing/payment form imbis na i-Close agad para iwas crash
        }

        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string deleteQuery = "DELETE FROM ordersTBL WHERE OrderID = @orderID";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", this.currentOrderID);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}