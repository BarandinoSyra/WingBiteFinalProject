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
    public partial class PaymentForm : Form
    {
        private string orderNumber;
        private double originalTotal;
        private double finalTotal;
        private const double DiscountRate = 0.15;
        public PaymentForm(string orderNum, double subtotal)
        {
            InitializeComponent();
            this.orderNumber = orderNum;
            this.originalTotal = subtotal;
            this.finalTotal = subtotal;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblOrderNumResult.Text = orderNumber;
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
            MessageBox.Show($"Payment successful via {method}! Transaction has been recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}