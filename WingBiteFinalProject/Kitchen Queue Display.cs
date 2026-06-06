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
        string connString = "Server=YJAIXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

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
                string query = @"SELECT k.QueueID, k.OrderID, k.timeSent, o.orderType
                                 FROM kitchenQueueTBL k
                                 JOIN ordersTBL o ON k.OrderID = o.OrderID
                                 WHERE k.status = @status
                                 ORDER BY k.timeSent ASC";

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
                MessageBox.Show("Please select an order first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int queueID = Convert.ToInt32(sourceDgv.SelectedRows[0].Cells["QueueID"].Value);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE kitchenQueueTBL SET status = @status WHERE QueueID = @queueID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@queueID", queueID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAllQueues();
            MessageBox.Show($"Order marked as {newStatus}.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            UpdateStatus(dgvPendingOrders, "Preparing");
        }

        private void btnServing_Click(object sender, EventArgs e)
        {
            UpdateStatus(dgvPreparingOrders, "Serving");
        
    }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (dgvReadyToServe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int queueID = Convert.ToInt32(dgvReadyToServe.SelectedRows[0].Cells["QueueID"].Value);
            int orderID = Convert.ToInt32(dgvReadyToServe.SelectedRows[0].Cells["OrderID"].Value);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateQueue = "UPDATE kitchenQueueTBL SET status = 'Completed' WHERE QueueID = @queueID";
                    SqlCommand cmd1 = new SqlCommand(updateQueue, conn, transaction);
                    cmd1.Parameters.AddWithValue("@queueID", queueID);
                    cmd1.ExecuteNonQuery();

                    string updateOrder = "UPDATE ordersTBL SET orderstatus = 'Completed' WHERE OrderID = @orderID";
                    SqlCommand cmd2 = new SqlCommand(updateOrder, conn, transaction);
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            LoadAllQueues();
            MessageBox.Show("Order marked as Completed.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            DataGridView selectedDgv = null;

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

            int orderID = Convert.ToInt32(selectedDgv.SelectedRows[0].Cells["OrderID"].Value);
            Order_status_or_order_dispatch orderStatus = new Order_status_or_order_dispatch(orderID);
            orderStatus.Show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Close();

        }
    }

}
