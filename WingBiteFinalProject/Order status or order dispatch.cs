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
    public partial class Order_status_or_order_dispatch : Form
    {
        string connString = "Server=YJIAXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private int _orderID;
        public Order_status_or_order_dispatch(int orderID)
        {
            InitializeComponent();
            _orderID = orderID;
            LoadOrderDetails();

        }
        private void LoadOrderDetails()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string orderQuery = "SELECT OrderID, TimePlaced, orderstatus FROM ordersTBL WHERE OrderID = @orderID";
                SqlCommand cmd = new SqlCommand(orderQuery, conn);
                cmd.Parameters.AddWithValue("@orderID", _orderID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblOrderNumHere.Text = reader["OrderID"].ToString();
                    lblTimePlacedHere.Text = Convert.ToDateTime(reader["TimePlaced"]).ToString("MM/dd/yyyy hh:mm tt");
                    lblCurrentStatus.Text = reader["orderstatus"].ToString();
                }
                reader.Close();

                string itemsQuery = @"SELECT p.productName AS Product, od.quantity AS Quantity, 
                                      od.unitPrice AS UnitPrice,
                                      (od.quantity * od.unitPrice) AS Total
                                      FROM orderDetailsTBL od
                                      JOIN productsTBL p ON od.productID = p.productID
                                      WHERE od.OrderID = @orderID";
                SqlCommand itemsCmd = new SqlCommand(itemsQuery, conn);
                itemsCmd.Parameters.AddWithValue("@orderID", _orderID);
                SqlDataReader itemsReader = itemsCmd.ExecuteReader();

                txtItems.Clear();
                while (itemsReader.Read())
                {
                    txtItems.AppendText($"{itemsReader["Product"]} x{itemsReader["Quantity"]} - ₱{itemsReader["UnitPrice"]} (Total: ₱{itemsReader["Total"]}){Environment.NewLine}");
                }
                itemsReader.Close();
            }
        }

        private void UpdateOrderStatus(string newStatus)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateOrder = "UPDATE ordersTBL SET orderstatus = @status WHERE OrderID = @orderID";
                    SqlCommand cmd1 = new SqlCommand(updateOrder, conn, transaction);
                    cmd1.Parameters.AddWithValue("@status", newStatus);
                    cmd1.Parameters.AddWithValue("@orderID", _orderID);
                    cmd1.ExecuteNonQuery();

                    string updateQueue = "UPDATE kitchenQueueTBL SET status = @status WHERE OrderID = @orderID";
                    SqlCommand cmd2 = new SqlCommand(updateQueue, conn, transaction);
                    cmd2.Parameters.AddWithValue("@status", newStatus);
                    cmd2.Parameters.AddWithValue("@orderID", _orderID);
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

            lblCurrentStatus.Text = newStatus;
            MessageBox.Show($"Order marked as {newStatus}.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMarkPreparing_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Preparing");
        }

        private void btnMarkPreparing_Click_1(object sender, EventArgs e)
        {
            UpdateOrderStatus("Preparing");
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Completed");

        }

        private void btnMarkServing_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Serving");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Kitchen_Queue_Display kitchen = new Kitchen_Queue_Display();
            kitchen.Show();
            this.Hide();

        }
    }
}
