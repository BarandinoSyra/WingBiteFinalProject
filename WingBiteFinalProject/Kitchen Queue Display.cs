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
                // BAGONG DAGDAG: Nilagyan natin ng explicit "o.OrderID AS [OrderID]" para siguradong 'OrderID' ang pangalan ng kolum sa DataTable
                string query = @"SELECT k.KitchenID, o.OrderID AS [OrderID], o.TimePlaced, o.orderType, o.orderstatus
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

            int orderID = GetSelectedOrderID(sourceDgv);

            if (orderID == 0)
            {
                MessageBox.Show("Could not retrieve Order ID from selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            LoadAllQueues();
        }

        // BAGONG METHOD: Isang safe na paraan para makuha ang OrderID kahit manu-mano o auto-generated ang column definitions mo
        private int GetSelectedOrderID(DataGridView dgv)
        {
            if (dgv.CurrentRow == null) return 0;

            // Subukan muna kunin gamit ang pangalan ng Column
            if (dgv.Columns.Contains("OrderID"))
            {
                return Convert.ToInt32(dgv.CurrentRow.Cells["OrderID"].Value);
            }

            // Kung ayaw pa rin sa pangalan, kukunin natin gamit ang pangalawang column (Index 1) dahil sa query natin, pangalawa ang o.OrderID
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

            // 1. Tinitingnan kung saan may aktibong focus/pinili ang user gamit ang bagong safe method natin
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
                // Fallback kung nawala ang focus sa grid habang kini-click ang button
                if (dgvPendingOrders.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvPendingOrders);
                else if (dgvPreparingOrders.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvPreparingOrders);
                else if (dgvReadyToServe.CurrentRow != null)
                    selectedOrderID = GetSelectedOrderID(dgvReadyToServe);
            }

            // 2. Pag sigurado nang may ID, ipapasa na natin ito sa Order Dispatch form
            if (selectedOrderID > 0)
            {
                Order_status_or_order_dispatch dispatchForm = new Order_status_or_order_dispatch(selectedOrderID);
                dispatchForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please click on a row containing an order number first before viewing details.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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