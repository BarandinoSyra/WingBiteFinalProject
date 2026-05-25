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
    public partial class Menu_or_Product_Module : Form
    {
        // Connection string mo
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public Menu_or_Product_Module()
        {
            InitializeComponent();
        }

        private void Menu_or_Product_Module_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        /// <summary>
        /// Naglo-load ng lahat ng produkto mula sa database papuntang DataGridView
        /// </summary>
        public void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Ginawang 'productsTBL' para pareho sa filter function mo
                    string query = "SELECT ProductID, ProductName, category, price, currentstock FROM productsTBL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;

                    if (dgvProducts.Columns["ProductID"] != null)
                    {
                        dgvProducts.Columns["ProductID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pwedeng iwanang walang laman kung walang click event ang cells mo
        }

        /// <summary>
        /// Ginagamit para maghanap ng partikular na produkto gamit ang textbox
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchProduct.Text.Trim()))
            {
                MessageBox.Show("Please enter a search Product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchItem = txtSearchProduct.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Inayos ang pangalan ng table papuntang 'productsTBL'
                    string query = "SELECT ProductID, ProductName, category, price, currentstock FROM productsTBL WHERE ProductName LIKE @SearchProduct";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchProduct", "%" + searchItem + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;

                    if (dgvProducts.Columns["ProductID"] != null)
                    {
                        dgvProducts.Columns["ProductID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Event kapag binago ang piniling kategorya sa ComboBox
        /// </summary>
        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterCategory.SelectedItem == null) return;

            string selectedCategory = cmbFilterCategory.SelectedItem.ToString();

            // Simulan ang base query gamit ang tamang table name (productsTBL) at tamang column (currentstock)
            string query = "SELECT ProductID, ProductName, category, price, currentstock FROM productsTBL";

            // Kung HINDI "ALL" o "All" ang pinili, magdagdag ng WHERE clause
            if (selectedCategory.ToUpper() != "ALL")
            {
                query += " WHERE category = @Category";
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Idagdag lang ang parameter kung hindi "ALL" ang pinili
                    if (selectedCategory.ToUpper() != "ALL")
                    {
                        cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProducts.DataSource = dt;

                    if (dgvProducts.Columns["ProductID"] != null)
                    {
                        dgvProducts.Columns["ProductID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Menu_or_Product_Module_Load_1(object sender, EventArgs e)
        {
            // Pwedeng burahin ito sa designer kung hindi ginagamit
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add = new Add_Product(this);
            add.Show();
            this.Hide();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Edit_Product_Search update = new Edit_Product_Search(this);
            update.Show();
            this.Hide();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a product row from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kuhanin ang detalye ng napiling produkto
            string productID = dgvProducts.CurrentRow.Cells["ProductID"].Value.ToString();
            string productName = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();

            // Mensahe para sa Kumpirmasyon (Confirmation Message Box)
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{productName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM productsTBL WHERE ProductID = @ProductID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // I-refresh ang DataGrid
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}