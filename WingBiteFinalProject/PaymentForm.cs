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

            // SAFE GUARD: Fallback to "Dine-In" if null or empty to prevent database constraints from throwing exceptions
            this.orderType = string.IsNullOrWhiteSpace(typeOfOrder) ? "Dine-In" : typeOfOrder;

            this.originalTotal = subtotal;
            this.finalTotal = subtotal;
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
            string computedChange = lblChangeResult.Text;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 1. Inserts the order metadata into ordersTBL and grabs the runtime Primary Key via SCOPE_IDENTITY()
                    string query = "INSERT INTO ordersTBL (TimePlaced, paymentMethod, orderstatus, orderType) VALUES (@TimePlaced, @paymentMethod, @orderstatus, @orderType); SELECT SCOPE_IDENTITY();";
                    int generatedOrderID = 0;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TimePlaced", DateTime.Now);
                        cmd.Parameters.AddWithValue("@paymentMethod", method);
                        cmd.Parameters.AddWithValue("@orderstatus", "Pending");
                        cmd.Parameters.AddWithValue("@orderType", this.orderType);

                        generatedOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                        this.currentOrderID = generatedOrderID;
                    }

                    // 2. Inserts workflow ticket into KitchenTBL using generatedOrderID explicitly as both KitchenID and OrderID.
                    // This dynamically handles your PK and NOT NULL database structural layout without changing the database.
                    string insertKitchenQuery = "INSERT INTO KitchenTBL (KitchenID, OrderID, Dispatch) VALUES (@kitchenID, @orderID, @dispatch)";
                    using (SqlCommand cmdKitchen = new SqlCommand(insertKitchenQuery, conn))
                    {
                        cmdKitchen.Parameters.AddWithValue("@kitchenID", generatedOrderID);
                        cmdKitchen.Parameters.AddWithValue("@orderID", generatedOrderID);
                        cmdKitchen.Parameters.AddWithValue("@dispatch", "Pending");
                        cmdKitchen.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment successful via {method}! Order #{this.currentOrderID} has been sent to the Kitchen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the transaction:\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 3. Spawns and shows the standard invoice or digital transactional receipt overview
            Transaction_Record receipt = new Transaction_Record(
                this.currentOrderID.ToString(),
                this.orderType,
                Convert.ToDecimal(this.originalTotal),
                Convert.ToDecimal(this.finalTotal),
                method,
                computedChange
            );
            receipt.Show();

            // 4. Hides the payment process form cleanly out of view without forcing another window to launch
            this.Hide();
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}