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
        private int currentOrderID; // Dito nakatabi ang ipinasang Auto-Increment ID mula sa Sales Module
        private const double DiscountRate = 0.15;

        private string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        // Constructor na may 3 parameters para tanggapin ang na-generate na numero agad
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
            // --- GAGAWING VISIBLE AT IPAPAKITA AGAD ANG ORDER NUMBER PAGKALOAD NG FORM ---
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

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // 1. UPDATE: I-update ang paymentMethod at gawing 'Paid' o kung ano man ang workflow mo
                    string updateOrderQuery = "UPDATE ordersTBL SET paymentMethod = @paymentMethod WHERE OrderID = @orderID";
                    using (SqlCommand cmdOrder = new SqlCommand(updateOrderQuery, conn))
                    {
                        cmdOrder.Parameters.AddWithValue("@paymentMethod", method);
                        cmdOrder.Parameters.AddWithValue("@orderID", this.currentOrderID);
                        cmdOrder.ExecuteNonQuery();
                    }

                    // 2. INSERT TO KITCHEN: Isama ang KitchenID (na gagamit din ng OrderID para pareho sila) at Dispatch
                    string insertKitchenQuery = "INSERT INTO KitchenTBL (KitchenID, OrderID, Dispatch) VALUES (@kitchenID, @orderID, @dispatch)";
                    using (SqlCommand cmdKitchen = new SqlCommand(insertKitchenQuery, conn))
                    {
                        cmdKitchen.Parameters.AddWithValue("@kitchenID", this.currentOrderID); // Gagamitin ang OrderID bilang KitchenID para iwas NULL error
                        cmdKitchen.Parameters.AddWithValue("@orderID", this.currentOrderID);
                        cmdKitchen.Parameters.AddWithValue("@dispatch", "Pending"); // Default string para sa bagong pasok na order
                        cmdKitchen.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment successful via {method}! Order #{this.currentOrderID} has been sent to the Kitchen.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the transaction:\n\n" + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            // Kung ayaw ituloy ang bayad, buburahin natin ang nakareserbang Order ID para malinis ang database
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
                    catch { /* Hayaang walang laman para tahimik na mag-close kung magka-error man */ }
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