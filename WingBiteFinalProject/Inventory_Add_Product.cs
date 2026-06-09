using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WingBiteFinalProject
{
    public partial class Inventory_Add_Product : Form
    {
        private string connectionString = "Data Source=DESKTOP-JG0361V\\SQLEXPRESS;Initial Catalog=WingBiteDB;Integrated Security=True;Encrypt=false";
        public Inventory_Add_Product()
        {
            InitializeComponent();
            GetInventoryID();
        }
        private void GetInventoryID()
        {
            string query = "SELECT IDENT_CURRENT('inventoryTBL') + 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            long nextID = Convert.ToInt64(result);
                            lblinventoryID.Text = nextID.ToString("D4");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sa pagkuha ng ID: " + ex.Message);
            }
        }

        private void lblMenuProductManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select a Category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please enter the Stock quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnit.Focus();
                return;
            }

            if (!int.TryParse(txtUnit.Text, out int stockValue))
            {
                MessageBox.Show("Stock must be a valid number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnit.Focus();
                return;
            }

            string id = lblinventoryID.Text;
            string category = cmbCategory.Text;

            string query = "INSERT INTO inventoryTBL (category, currentstock, adjustStock) VALUES (@Category, @Stock, @AdjustStock)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@Stock", int.Parse(txtUnit.Text));
                        cmd.Parameters.AddWithValue("@AdjustStock", 0);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product successfully saved to database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 1. I-refresh muna ang inputs at ID sa loob ng form na ito
                ClearInputs();
                GetInventoryID();

                // 2. Opsyonal: I-update ang Inventory_Tracking kung ito ay open na
                // Kung gusto mo lang bumalik sa listahan, gawin ito:
                Inventory_Tracking inventoryTrackingForm = new Inventory_Tracking();
                inventoryTrackingForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            cmbCategory.SelectedIndex = -1;
            txtUnit.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory_Tracking inventory = new Inventory_Tracking();
            inventory.Show();
            this.Hide();
        }

        private void Inventory_Add_Product_Load(object sender, EventArgs e)
        {
            GetInventoryID();
        }
    }
}
    

