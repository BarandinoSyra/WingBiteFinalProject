using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WingBiteFinalProject;

namespace WingBiteFinalProject
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private Menu_or_Product_Module _mainForm;

        // Baguhin ang Constructor para tanggapin ang Main Form reference
        public Add_Product(Menu_or_Product_Module mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private bool DoesInventoryIDExist(int id)
        {
            string checkQuery = "SELECT COUNT(1) FROM inventoryTBL WHERE inventoryID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(checkQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu_or_Product_Module menuForm = new Menu_or_Product_Module();
            menuForm.ShowDialog();
            this.Hide();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text.Trim()) ||
         cmbCategory.SelectedItem == null ||
         string.IsNullOrEmpty(txtUnit.Text.Trim()) ||
         string.IsNullOrEmpty(txtPrice.Text.Trim()) ||
         string.IsNullOrEmpty(txtInventoryID.Text.Trim()))
            {
                MessageBox.Show("Please fill out all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Make sure it is actually a valid integer
            if (!int.TryParse(txtInventoryID.Text.Trim(), out int inventoryID))
            {
                MessageBox.Show("Inventory ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Database check: Does this Inventory ID actually exist?
            if (!DoesInventoryIDExist(inventoryID))
            {
                MessageBox.Show($"The Inventory ID '{inventoryID}' does not exist in the system. Please verify the ID or create the inventory item first.",
                                "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to save this new product?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "INSERT INTO productsTBL (InventoryID, ProductName, category, currentstock, price) VALUES (@InventoryID, @Name, @Category, @Stock, @Price)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtUnit.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@InventoryID", inventoryID); // Used parsed int variable

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Safely refresh and handle window state
                        if (_mainForm != null)
                        {
                            _mainForm.LoadProducts();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void picboxMenuProductManagement_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuProductManagement_Click(object sender, EventArgs e)
        {

        }
    }
}
