using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WingBiteFinalProject
{
    public partial class Edit_Product_Details : Form
    {
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private Menu_or_Product_Module _mainForm;
        private string _productID;

        // Constructor na tumatanggap ng mga lumang detalye ng produkto mula sa Search Form
        public Edit_Product_Details(Menu_or_Product_Module mainForm, string id, string name, string category)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _productID = id;

            // Ipakita ang detalye sa mga UI controls mo base sa iyong design layout
            lblProductIDResult.Text = id; // Label para sa "Product ID here:"
            lblProductNameResult.Text = name;
            lblCategory.Text = category;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Product_Details_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblProductName.Text.Trim()) || txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Fields cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kumpirmasyon bago baguhin sa database
            DialogResult result = MessageBox.Show("Are you sure you want to update this product's information?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "UPDATE productsTBL SET ProductName = @Name, category = @Category, currentstock = @Stock, price = @Price WHERE ProductID = @ID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", lblProductNameResult.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", lblCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtUnit.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ID", _productID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // I-refresh ang grid sa Main Form at isara ang bintana na ito
                        _mainForm.LoadProducts();
                        this.Close();

                        Menu_or_Product_Module menu = new Menu_or_Product_Module();
                        menu.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}