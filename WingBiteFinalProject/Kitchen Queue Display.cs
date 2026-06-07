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
    public partial class Kitchen_Queue_Display : Form
    {
        private string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public Kitchen_Queue_Display()
        {
            InitializeComponent();
            LoadAllQueues();
        }

        private void LoadAllQueues()
        {
            LoadQueue(dgvPendingOrders, "Pending");
            LoadQueue(dgvPreparingOrders, "Preparing");
            LoadQueue(dgvReadyToServe, "Serving");
        }

        private void LoadQueue(DataGridView dgv, string status)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT k.KitchenID, o.OrderID AS [OrderID], o.TimePlaced, o.orderType, o.orderstatus
                                 FROM KitchenTBL k
                                 JOIN ordersTBL o ON k.OrderID = o.OrderID
                                 WHERE o.orderstatus = @status
                                 ORDER BY o.OrderID DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                StyleGrid(dgv);
            }
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateStatus(DataGridView sourceDgv, string newStatus)
        {
            if (sourceDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderID = GetSelectedOrderID(sourceDgv);

            if (orderID == 0)
            {
                MessageBox.Show("Could not retrieve a valid Order ID from the selected row.", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Dito mo ilalagay ang pinagsamang update query para mag-sync ang dalawang table
                string query = @"UPDATE ordersTBL SET orderstatus = @status WHERE OrderID = @orderID;
                         UPDATE KitchenTBL SET Dispatch = @status WHERE OrderID = @orderID;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@orderID", orderID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Order #{orderID} status successfully updated to '{newStatus}'.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the database status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadAllQueues();
        }

        private int GetSelectedOrderID(DataGridView dgv)
        {
            if (dgv.CurrentRow == null) return 0;

            if (dgv.Columns.Contains("OrderID"))
            {
                return Convert.ToInt32(dgv.CurrentRow.Cells["OrderID"].Value);
            }

            return Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            UpdateStatus(dgvPendingOrders, "Preparing");
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            UpdateStatus(dgvReadyToServe, "Completed");
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            int selectedOrderID = 0;

            if (dgvPendingOrders.CurrentRow != null && dgvPendingOrders.ContainsFocus)
            {
                selectedOrderID = GetSelectedOrderID(dgvPendingOrders);
            }
            else if (dgvPreparingOrders.CurrentRow != null && dgvPreparingOrders.ContainsFocus)
            {
                selectedOrderID = GetSelectedOrderID(dgvPreparingOrders);
            }
            else if (dgvReadyToServe.CurrentRow != null && dgvReadyToServe.ContainsFocus)
            {
                selectedOrderID = GetSelectedOrderID(dgvReadyToServe);
            }
            else
            {
                if (dgvPendingOrders.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvPendingOrders);
                else if (dgvPreparingOrders.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvPreparingOrders);
                else if (dgvReadyToServe.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvReadyToServe);
            }

            if (selectedOrderID > 0)
            {
                Order_status_or_order_dispatch dispatchForm = new Order_status_or_order_dispatch(selectedOrderID);
                dispatchForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please click on a valid row containing an order record before viewing details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Close();
        }

        private void btnServing_Click_1(object sender, EventArgs e)
        {
            UpdateStatus(dgvPreparingOrders, "Serving");
        }
    }
}