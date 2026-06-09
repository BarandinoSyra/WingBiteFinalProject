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
    public partial class Inventory_archive : Form
    {
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private int selectedInventoryID = -1;

        public Inventory_archive()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Inventory_archive_Load);
            this.dgvarchive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarchive_CellClick);
        }

        private void Inventory_archive_Load(object sender, EventArgs e)
        {
            panelDisplay.Visible = false;
            LoadArchivedInventory();
        }

        public void LoadArchivedInventory()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                             RIGHT('0000' + CAST(inventoryID AS VARCHAR), 4) AS [Inventory ID],
                             category AS [Category], 
                             currentstock AS [Stock], 
                             FORMAT(lastupdated, 'MMMM dd, yyyy hh:mm tt') AS [Date Removed],
                             inventoryID
                             FROM inventoryTBL
                             WHERE isArchived = 1
                             ORDER BY inventoryID DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvarchive.DataSource = dt;

                    if (dgvarchive.Columns["inventoryID"] != null)
                    {
                        dgvarchive.Columns["inventoryID"].Visible = false;
                    }
                    dgvarchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvarchive.ClearSelection();
                    ResetSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading archived items: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvarchive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvarchive.Rows[e.RowIndex];

                if (row.Cells["inventoryID"].Value != DBNull.Value && row.Cells["inventoryID"].Value != null)
                {
                    selectedInventoryID = Convert.ToInt32(row.Cells["inventoryID"].Value);
                    lblInventoryID.Text = row.Cells["Inventory ID"].Value?.ToString() ?? "";
                    lblCategory.Text = row.Cells["Category"].Value?.ToString() ?? "";
                    txtStock.Text = row.Cells["Stock"].Value?.ToString() ?? "0";
                }
            }
        }

        private void btndisplay1_Click(object sender, EventArgs e)
        {
            if (selectedInventoryID == -1)
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int updatedStock) || updatedStock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = "UPDATE inventoryTBL SET currentstock = @Stock, isArchived = 0, lastupdated = GETDATE() WHERE inventoryID = @InventoryID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Stock", updatedStock);
                        cmd.Parameters.AddWithValue("@InventoryID", selectedInventoryID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product has been successfully restored to the active inventory display!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            panelDisplay.Visible = false;
                            LoadArchivedInventory();

                            Inventory_Tracking trackingForm = (Inventory_Tracking)Application.OpenForms["Inventory_Tracking"];
                            if (trackingForm != null)
                            {
                                trackingForm.LoadInventory();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to restore product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while restoring: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            
        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            if (selectedInventoryID == -1)
            {
                panelDisplay.Visible = false;
                MessageBox.Show("Please select an archived product from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panelDisplay.Visible = true;

        }
        

        private void btnDeletePermanent_Click_1(object sender, EventArgs e)
        {
            if (selectedInventoryID == -1)
            {
                MessageBox.Show("Please select a product to delete permanently.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to PERMANENTLY DELETE this product from the entire database? This action cannot be undone.", "Confirm Permanent Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM inventoryTBL WHERE inventoryID = @InventoryID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@InventoryID", selectedInventoryID);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product has been permanently removed from the database.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                panelDisplay.Visible = false;
                                LoadArchivedInventory();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the product. It may no longer exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory_Tracking trackingForm = (Inventory_Tracking)Application.OpenForms["Inventory_Tracking"];
            if (trackingForm != null)
            {
                trackingForm.LoadInventory();
                trackingForm.Show();
            }
            else
            {
                Inventory_Tracking newTracking = new Inventory_Tracking();
                newTracking.Show();
            }
            this.Close();
        }

        private void ResetSelection()
        {
            selectedInventoryID = -1;
            panelDisplay.Visible = false;
            lblInventoryID.Text = "";
            lblCategory.Text = "";
            txtStock.Clear();
        }

        private void dgvarchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Inventory_Tracking tracking =new Inventory_Tracking();
            tracking.Show();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelDisplay.Hide();

        }
    }
}