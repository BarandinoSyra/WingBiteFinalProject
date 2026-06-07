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
        // Connection string patungo sa iyong lokal na SQLEXPRESS database
        private string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public Kitchen_Queue_Display()
        {
            InitializeComponent();
            LoadAllQueues();
        }

        // Method para sabay-sabay na i-refresh ang tatlong DataGridView
        private void LoadAllQueues()
        {
            LoadQueue(dgvPendingOrders, "Pending");
            LoadQueue(dgvPreparingOrders, "Preparing");
            LoadQueue(dgvReadyToServe, "Serving");
        }

        // Pagkuha ng data base sa totoong schema ng KitchenTBL at ordersTBL mo
        private void LoadQueue(DataGridView dgv, string status)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT k.KitchenID, k.OrderID, o.TimePlaced, o.orderType, o.orderstatus
                                 FROM KitchenTBL k
                                 JOIN ordersTBL o ON k.OrderID = o.OrderID
                                 WHERE o.orderstatus = @status
                                 ORDER BY o.TimePlaced ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                StyleGrid(dgv);
            }
        }

        // Disenyo para sa mga DataGridView para maging malinis tingnan
        private void StyleGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Pangkalahatang method para sa pag-update ng orderstatus sa ordersTBL
        private void UpdateStatus(DataGridView sourceDgv, string newStatus)
        {
            if (sourceDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kukuha ng OrderID mula sa piniling hilera (row) sa DataGridView
            int orderID = Convert.ToInt32(sourceDgv.SelectedRows[0].Cells["OrderID"].Value);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE ordersTBL SET orderstatus = @status WHERE OrderID = @orderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@orderID", orderID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Order marked as {newStatus}.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // I-refresh ang display pagkatapos mag-update
            LoadAllQueues();
        }

        // --- MGA EVENT HANDLERS PARA SA MGA BUTTONS ---

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            // Pag pinindot ito, kukunin ang data sa Pending Grid at gagawing 'Preparing'
            UpdateStatus(dgvPendingOrders, "Preparing");
        }

       

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            // Pag pinindot ito, kukunin ang data sa Ready to Serve Grid at gagawing 'Completed'
            UpdateStatus(dgvReadyToServe, "Completed");
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            DataGridView selectedDgv = null;

            // Alamin kung saang DataGridView may nakapiling (selected) row
            if (dgvPendingOrders.SelectedRows.Count > 0)
                selectedDgv = dgvPendingOrders;
            else if (dgvPreparingOrders.SelectedRows.Count > 0)
                selectedDgv = dgvPreparingOrders;
            else if (dgvReadyToServe.SelectedRows.Count > 0)
                selectedDgv = dgvReadyToServe;

            if (selectedDgv == null)
            {
                MessageBox.Show("Please select an order first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buksan ang Order status form gamit ang napiling OrderID
            int orderID = Convert.ToInt32(selectedDgv.SelectedRows[0].Cells["OrderID"].Value);
            Order_status_or_order_dispatch orderStatus = new Order_status_or_order_dispatch(orderID);
            orderStatus.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Bumalik sa Main Page at isara ang kasalukuyang screen
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