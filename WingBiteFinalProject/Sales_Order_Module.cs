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
    public partial class Sales_Order_Module : Form
    {
        public Sales_Order_Module()
        {
            InitializeComponent();
            SetupCurrentOrderDGV();
            txtQuantity.Enabled = false;
            btnAddToOrder.Enabled = false;
            rbAll.Checked = true;
        }

        private string connString = @"Data Source=DESKTOP-JG0361V\SQLEXPRESS;Initial Catalog=WingBiteDB;Integrated Security=True";

        private void SetupCurrentOrderDGV()
        {
            dgvCurrentOrder.Columns.Clear();
            dgvCurrentOrder.Columns.Add("ProductID", "ID");
            dgvCurrentOrder.Columns.Add("OrderType", "Type");
            dgvCurrentOrder.Columns.Add("ProductName", "Product Name");
            dgvCurrentOrder.Columns.Add("Price", "Price");
            dgvCurrentOrder.Columns.Add("Quantity", "Qty");
            dgvCurrentOrder.Columns.Add("Total", "Total");
            dgvCurrentOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentOrder.Columns["ProductID"].Visible = false;
        }

        private void LoadMenuItems(string category)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "";

                if (category == "All")
                {
                    query = "SELECT productID, productName, Price, currentstock FROM productsTBL";
                }
                else
                {
                    query = "SELECT productID,productName, Price, currentstock FROM productsTBL WHERE Category = @Category";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (category != "All")
                    {
                        cmd.Parameters.AddWithValue("@Category", category);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        da.Fill(dt);
                        dgvMenuItems.DataSource = dt;
                        dgvMenuItems.Columns["productID"].Visible = false;
                        dgvMenuItems.Columns["productName"].HeaderText = "Product Name";
                        dgvMenuItems.Columns["Price"].HeaderText = "Price";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbWings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWings.Checked) LoadMenuItems("Wings");
        }

        private void rbRicePlatter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRicePlatter.Checked) LoadMenuItems("RicePlatter");
        }

        private void rbDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDrinks.Checked) LoadMenuItems("Drinks");
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Please select a product from Menu Items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int inputQty) || inputQty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Please enter the Order # before adding an item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderNumber.Focus();
                return;
            }

            string orderNo = txtOrderNumber.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string checkOrderQuery = "SELECT COUNT(*) FROM ordersTBL WHERE OrderID = @OrderNo";
                using (SqlCommand checkCmd = new SqlCommand(checkOrderQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@OrderNo", orderNo);
                    try
                    {
                        conn.Open();
                        int orderCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (orderCount > 0)
                        {
                            MessageBox.Show($"Order # '{orderNo}' has already been used in a previous transaction. Please enter a new Order #.",
                                            "Duplicate Order Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtOrderNumber.Focus();
                            txtOrderNumber.SelectAll();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error verifying Order #: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            string selectedOrderType = cmbOrderType.SelectedItem != null ? cmbOrderType.SelectedItem.ToString() : "Dine In";
            string prodID = dgvMenuItems.CurrentRow.Cells["productID"].Value.ToString();
            string prodName = dgvMenuItems.CurrentRow.Cells["productName"].Value.ToString();
            double price = Convert.ToDouble(dgvMenuItems.CurrentRow.Cells["Price"].Value);
            int databaseStock = Convert.ToInt32(dgvMenuItems.CurrentRow.Cells["currentstock"].Value);

            if (databaseStock < inputQty)
            {
                MessageBox.Show($"Insufficient stock! Only {databaseStock} remaining.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string updateQuery = "UPDATE productsTBL SET currentstock = currentstock - @InputQty WHERE productID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@InputQty", inputQty);
                    cmd.Parameters.AddWithValue("@ProductID", prodID);
                    try { conn.Open(); cmd.ExecuteNonQuery(); }
                    catch (Exception ex) { MessageBox.Show("Error updating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
            }

            double total = price * inputQty;
            dgvCurrentOrder.Rows.Add(prodID, selectedOrderType, prodName, price, inputQty, total);
            RefreshMenuGrid();
            UpdateSubtotal();

            txtQuantity.Clear();
            dgvMenuItems.ClearSelection();
            txtQuantity.Enabled = false;
            btnAddToOrder.Enabled = false;
        }

        private void RefreshMenuGrid()
        {
            if (rbAll.Checked) LoadMenuItems("All");
            else if (rbWings.Checked) LoadMenuItems("Wings");
            else if (rbRicePlatter.Checked) LoadMenuItems("RicePlatter");
            else if (rbDrinks.Checked) LoadMenuItems("Drinks");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.CurrentRow == null || dgvCurrentOrder.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an item from the Current Order to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prodID = dgvCurrentOrder.CurrentRow.Cells["ProductID"].Value.ToString();
            string itemName = dgvCurrentOrder.CurrentRow.Cells["ProductName"].Value.ToString();
            int qtyToReturn = Convert.ToInt32(dgvCurrentOrder.CurrentRow.Cells["Quantity"].Value);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove '{itemName}' from the order?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string returnQuery = "UPDATE productsTBL SET currentstock = currentstock + @Qty WHERE productID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(returnQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qtyToReturn);
                        cmd.Parameters.AddWithValue("@ProductID", prodID);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error returning stock to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                dgvCurrentOrder.Rows.Remove(dgvCurrentOrder.CurrentRow);
                RefreshMenuGrid();
                UpdateSubtotal();
                dgvMenuItems.ClearSelection();
                txtQuantity.Clear();
                txtQuantity.Enabled = false;
                btnAddToOrder.Enabled = false;
            }
        }

        private void UpdateSubtotal()
        {
            double subtotal = 0;
            foreach (DataGridViewRow row in dgvCurrentOrder.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDouble(row.Cells["Total"].Value);
                }
            }
            lblSubtotal.Text = subtotal.ToString("C2");
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.Rows.Count == 0)
            {
                MessageBox.Show("The current order is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to clear the entire order? This will restore product stock levels.", "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        foreach (DataGridViewRow row in dgvCurrentOrder.Rows)
                        {
                            if (row.IsNewRow) continue;
                            if (row.Cells["ProductID"].Value != null)
                            {
                                string prodID = row.Cells["ProductID"].Value.ToString();
                                int qtyToReturn = Convert.ToInt32(row.Cells["Quantity"].Value);
                                string returnQuery = "UPDATE productsTBL SET currentstock = currentstock + @Qty WHERE productID = @ProductID";
                                using (SqlCommand cmd = new SqlCommand(returnQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Qty", qtyToReturn);
                                    cmd.Parameters.AddWithValue("@ProductID", prodID);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Warning: An item without a Product ID was detected. Its stock cannot be restored.", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        dgvCurrentOrder.Rows.Clear();
                        RefreshMenuGrid();
                        UpdateSubtotal();
                        txtOrderNumber.Clear();
                        MessageBox.Show("Order cleared and stocks restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error restoring stocks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtOrderNumber.Text)) return;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT productID, productName, price, quantity, total FROM salesTBL WHERE OrderID = @OrderID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderNumber.Text);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dgvCurrentOrder.Rows.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dgvCurrentOrder.Rows.Add(
                                    reader["productID"],
                                    "Dine In",
                                    reader["productName"],
                                    reader["price"],
                                    reader["quantity"],
                                    reader["total"]
                                );
                            }
                            UpdateSubtotal();
                            MessageBox.Show("Order found and loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Order Number not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error searching order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Sales_Order_Module_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.Rows.Count == 0)
            {
                MessageBox.Show("There is no order to checkout.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text))
            {
                MessageBox.Show("Please enter the Order #.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderNumber.Focus();
                return;
            }

            string orderNo = txtOrderNumber.Text.Trim();
            string orderType = cmbOrderType.SelectedItem != null ? cmbOrderType.SelectedItem.ToString() : "Dine In";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int currentOrderID = 0;
                    string insertOrderQuery = @"INSERT INTO ordersTBL (OrderNo, OrderType, OrderDate) 
                                               VALUES (@OrderNo, @OrderType, GETDATE());
                                               SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn, transaction))
                    {
                        cmdOrder.Parameters.AddWithValue("@OrderNo", orderNo);
                        cmdOrder.Parameters.AddWithValue("@OrderType", orderType);
                        currentOrderID = Convert.ToInt32(cmdOrder.ExecuteScalar());
                    }

                    string insertSalesQuery = @"INSERT INTO salesTBL (OrderID, prod_ID, quantity, unitPrice) 
                                               VALUES (@OrderID, @ProdID, @Quantity, @UnitPrice)";

                    foreach (DataGridViewRow row in dgvCurrentOrder.Rows)
                    {
                        if (row.IsNewRow) continue;

                        using (SqlCommand cmdSales = new SqlCommand(insertSalesQuery, conn, transaction))
                        {
                            long prodID = Convert.ToInt64(row.Cells["ProductID"].Value);
                            int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                            double unitPrice = Convert.ToDouble(row.Cells["Price"].Value);

                            cmdSales.Parameters.AddWithValue("@OrderID", currentOrderID);
                            cmdSales.Parameters.AddWithValue("@ProdID", prodID);
                            cmdSales.Parameters.AddWithValue("@Quantity", qty);
                            cmdSales.Parameters.AddWithValue("@UnitPrice", unitPrice);

                            cmdSales.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCurrentOrder.Rows.Clear();
                    txtOrderNumber.Clear();
                    txtQuantity.Clear();
                    UpdateSubtotal();
                    RefreshMenuGrid();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing Checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMenuItems.CurrentRow != null && dgvMenuItems.CurrentRow.Index >= 0)
            {
                txtQuantity.Enabled = true;
                btnAddToOrder.Enabled = true;
            }
            else
            {
                txtQuantity.Enabled = false;
                btnAddToOrder.Enabled = false;
                txtQuantity.Clear();
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                LoadMenuItems("All");
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}