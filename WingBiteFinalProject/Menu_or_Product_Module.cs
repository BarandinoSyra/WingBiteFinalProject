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
       
        private readonly string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

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

            string query = "SELECT productID, productName, category, price,currentstock, ProductsSold FROM ProductsTBL";
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
                                product.Price = Convert.ToDecimal(reader["price"]);
                                product.Stock = reader["currentstock"] == DBNull.Value ? 0 : Convert.ToInt32(reader["currentstock"]);
                                product.ProductsSold = reader["ProductsSold"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ProductsSold"]);

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
            dgvProducts.DataSource = null;
            dgvProducts.Columns.Clear();
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.Columns.Add("ProductID", "Product ID");
            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Price", "Price");
            dgvProducts.Columns.Add("Stock", "Current Stock");
            dgvProducts.Columns.Add("ProductsSold", "Products Sold");
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "C2";
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    product.Stock,
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
                        product.Stock,
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
                        product.Stock,
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

            DialogResult result = MessageBox.Show("Are you sure? The stock will be returned to inventory.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int selectedID = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Kunin ang InventoryID at stock ng product na dine-delete
                    string getInfoQuery = "SELECT InventoryID, currentstock FROM ProductsTBL WHERE productID = @PID";
                    SqlCommand cmdGet = new SqlCommand(getInfoQuery, conn, transaction);
                    cmdGet.Parameters.AddWithValue("@PID", selectedID);

                    int invID = 0;
                    int stockToReturn = 0;

                    using (SqlDataReader reader = cmdGet.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            invID = Convert.ToInt32(reader["InventoryID"]);
                            stockToReturn = Convert.ToInt32(reader["currentstock"]);
                        }
                        reader.Close();
                    }

                    // 2. I-ADD pabalik ang stock sa Inventory
                    string returnStockQuery = "UPDATE inventoryTBL SET currentstock = currentstock + @Qty WHERE inventoryID = @InvID";
                    SqlCommand cmdReturn = new SqlCommand(returnStockQuery, conn, transaction);
                    cmdReturn.Parameters.AddWithValue("@Qty", stockToReturn);
                    cmdReturn.Parameters.AddWithValue("@InvID", invID);
                    cmdReturn.ExecuteNonQuery();

                    // 3. I-DELETE ang product
                    string deleteQuery = "DELETE FROM ProductsTBL WHERE productID = @PID";
                    SqlCommand cmdDel = new SqlCommand(deleteQuery, conn, transaction);
                    cmdDel.Parameters.AddWithValue("@PID", selectedID);
                    cmdDel.ExecuteNonQuery();

                    transaction.Commit();

                    // 4. Update local memory (ProductData)
                    Product productToDelete = ProductData.products.FirstOrDefault(p => p.ProductID == selectedID);
                    if (productToDelete != null)
                    {
                        ProductData.products.Remove(productToDelete);
                        SystemData.Products.Remove(productToDelete);
                    }

                    LoadAllProducts();
                    MessageBox.Show("Product deleted and stock returned successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to delete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            SetupProductGrid();
            LoadAllProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
