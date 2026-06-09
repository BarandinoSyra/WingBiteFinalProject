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
    public partial class Inventory_Tracking : Form
    {
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private int selectedInventoryID = -1;

        public Inventory_Tracking()
        {
            InitializeComponent();
            lblProductNameHere.Visible = false;
            lblCurrentStockResult.Visible = false;
            this.Load += new System.EventHandler(this.Inventory_Tracking_Load_1);
            this.dgvInventory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInventory_DataBindingComplete);
        }

        private void Inventory_Tracking_Load_1(object sender, EventArgs e)
        {
            LoadInventory();
        }

        public void LoadInventory()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // In-update ang FORMAT ng 'Last Updated' para tumulad sa 'Date Received'
                    string query = @"SELECT 
                                     RIGHT('0000' + CAST(inventoryID AS VARCHAR), 4) AS [Inventory ID],
                                     category AS [Category], 
                                     currentstock AS [Stock], 
                                     CASE 
                                         WHEN currentstock <= 0 THEN 'Out Of Stock'
                                         WHEN currentstock <= 10 THEN 'Low Stock'
                                         ELSE 'In Stock'
                                     END AS [Stock Status],
                                     FORMAT(dateReceived, 'MMMM dd, yyyy') AS [Date Received], 
                                     FORMAT(lastupdated, 'MMMM dd, yyyy') AS [Last Updated],
                                     inventoryID
                                     FROM inventoryTBL
                                     WHERE isArchived = 0 OR isArchived IS NULL";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInventory.DataSource = dt;

                    if (dgvInventory.Columns["inventoryID"] != null)
                    {
                        dgvInventory.Columns["inventoryID"].Visible = false;
                    }
                    dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvInventory.ClearSelection();
                    selectedInventoryID = -1;
                    lblProductNameHere.Text = "Product Name here";
                    lblCurrentStockResult.Text = "Current Stock here";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventory.ClearSelection();
        }

        private void btnLowStockReport_Click(object sender, EventArgs e)
        {
            Show_Low_Stock_report lowStock = new Show_Low_Stock_report();
            lowStock.Show();
            this.Hide();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Inventory_Add_Product addinvproduct = new Inventory_Add_Product();
            addinvproduct.Show();
            this.Hide();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                if (row.Cells["inventoryID"].Value != DBNull.Value && row.Cells["inventoryID"].Value != null)
                {
                    selectedInventoryID = Convert.ToInt32(row.Cells["inventoryID"].Value);
                    lblProductNameHere.Text = row.Cells["Category"].Value?.ToString() ?? "";
                    lblCurrentStockResult.Text = row.Cells["Stock"].Value?.ToString() ?? "0";
                    lblProductNameHere.Visible = true;
                    lblCurrentStockResult.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvInventory.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("Category LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"));
            }
            else
            {
                MessageBox.Show("No data available to filter. Please try refreshing the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (dgvInventory.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (selectedInventoryID == -1)
            {
                MessageBox.Show("Please select a product from the list above first.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAdjustProduct.Text, out int newStock))
            {
                MessageBox.Show("Please enter a valid numeric value for Adjust Stock.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string updateQuery = "UPDATE inventoryTBL SET currentstock = @NewStock, lastupdated = GETDATE() WHERE inventoryID = @InventoryID";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewStock", newStock);
                        cmd.Parameters.AddWithValue("@InventoryID", selectedInventoryID);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAdjustProduct.Clear();
                            lblCurrentStockResult.Text = newStock.ToString();
                            LoadInventory();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInventory();
            lblCurrentStockResult.Visible = false;
            lblProductNameHere.Visible = false;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (selectedInventoryID == -1)
            {
                MessageBox.Show("Please select a product from the list to archive first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to remove this product and move it to the archive section?", "Confirm Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string archiveQuery = "UPDATE inventoryTBL SET isArchived = 1, lastupdated = GETDATE() WHERE inventoryID = @InventoryID";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(archiveQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@InventoryID", selectedInventoryID);
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product has been successfully moved to the archive.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadInventory();
                            }
                            else
                            {
                                MessageBox.Show("Failed to archive the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while archiving: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Inventory_archive archiveForm = new Inventory_archive();
            archiveForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();
        }
    }
}