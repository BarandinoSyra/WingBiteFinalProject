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
                        string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Please fill out all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kumpirmasyon bago i-save
            DialogResult result = MessageBox.Show("Do you want to save this new product?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Idagdag ang @InventoryID sa VALUES clause
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
                        cmd.Parameters.AddWithValue("@InventoryID", Convert.ToInt32(txtInventoryID.Text.Trim()));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // I-refresh ang grid sa Main Form at isara ang window na ito
                        _mainForm.LoadProducts();
                        Menu_or_Product_Module menu = new Menu_or_Product_Module();
                        menu.Show();
                        this.Hide();
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
