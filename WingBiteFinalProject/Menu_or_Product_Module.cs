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
       
        private readonly string connString = "Server=YJAIXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public Menu_or_Product_Module()
        {
            InitializeComponent();
        }

       
        private void Menu_or_Product_Module_Load(object sender, EventArgs e)
        {
            LoadProductsFromDatabase();
            LoadCategory();
            SetupProductGrid();
            LoadAllProducts();
        }

        public void LoadProductsFromDatabase()
        {
            ProductData.products.Clear();
            SystemData.Products.Clear();

            string query = "SELECT productID, productName, category, unit, price FROM ProductsTBL";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.ProductID = Convert.ToInt32(reader["productID"]);
                                product.ProductName = reader["productName"].ToString();
                                product.Category = reader["category"].ToString();
                                product.Stock = Convert.ToInt32(reader["unit"]);
                                product.Price = Convert.ToDecimal(reader["price"]);
                                product.ProductsSold = 0;

                                ProductData.products.Add(product);
                                SystemData.Products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading database records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategory()
        {
            cmbFilterCategory.Items.Clear();
            cmbFilterCategory.Items.Add("Wings");
            cmbFilterCategory.Items.Add("Rice Platter");
            cmbFilterCategory.Items.Add("Drinks");
            cmbFilterCategory.SelectedIndex = -1;
        }

        private void SetupProductGrid()
        {
            dgvProducts.DataSource = null; // Tinitiyak na walang nakatalang datasource upang maiwasan ang binding crash
            dgvProducts.Columns.Clear();
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.Columns.Add("ProductID", "Product ID");
            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price");
            dgvProducts.Columns.Add("ProductsSold", "Products Sold");
        }

        public void LoadAllProducts()
        {
            dgvProducts.Rows.Clear();
            foreach (Product product in ProductData.products)
            {
                dgvProducts.Rows.Add(
                    product.ProductID,
                    product.ProductName,
                    product.Category,
                    product.Price,
                    product.ProductsSold);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchProduct = txtSearchProduct.Text.Trim().ToLower();
            dgvProducts.Rows.Clear();
            bool found = false;
            if (searchProduct == "")
            {
                LoadAllProducts();
                return;
            }
            foreach (Product product in ProductData.products)
            {
                if (product.ProductName.ToLower().Contains(searchProduct))
                {
                    dgvProducts.Rows.Add(
                        product.ProductID,
                        product.ProductName,
                        product.Category,
                        product.Price,
                        product.ProductsSold);
                    found = true;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Product does not exist.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllProducts();
            }
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterCategory.SelectedIndex == -1)
            {
                LoadAllProducts();
                return;
            }
            string selectedCategory = cmbFilterCategory.SelectedItem.ToString();
            dgvProducts.Rows.Clear();

            foreach (Product product in ProductData.products)
            {
                if (product.Category == selectedCategory)
                {
                    dgvProducts.Rows.Add(
                        product.ProductID,
                        product.ProductName,
                        product.Category,
                        product.Price,
                        product.ProductsSold);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add = new Add_Product();
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
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            int selectedID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);

            string query = "DELETE FROM ProductsTBL WHERE productID = @ID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete from database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product productToDelete = null;
            foreach (Product product in ProductData.products)
            {
                if (product.ProductID == selectedID)
                {
                    productToDelete = product;
                    break;
                }
            }
            if (productToDelete != null)
            {
                ProductData.products.Remove(productToDelete);
                SystemData.Products.Remove(productToDelete);
            }
            LoadAllProducts();
            MessageBox.Show("Product deleted successfully!", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = SystemData.Products;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
