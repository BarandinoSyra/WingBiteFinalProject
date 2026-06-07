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
        private string connString = @"Data Source=DESKTOP-JG0361V\SQLEXPRESS;Initial Catalog=WingBiteDB;Integrated Security=True";

        public Sales_Order_Module()
        {
            InitializeComponent();
            SetupCurrentOrderDGV();
            txtQuantity.Enabled = false;
            btnAddToOrder.Enabled = false;
            rbAll.Checked = true;
            LoadMenuItems("All");
        }

        private void SetupCurrentOrderDGV()
        {
            dgvCurrentOrder.Columns.Clear();
            dgvCurrentOrder.Columns.Add("Type", "Type");
            dgvCurrentOrder.Columns.Add("ProductName", "Product Name");
            dgvCurrentOrder.Columns.Add("Price", "Price");
            dgvCurrentOrder.Columns.Add("Quantity", "Qty");
            dgvCurrentOrder.Columns.Add("Total", "Total");
            dgvCurrentOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCurrentOrder.ClearSelection();
        }

        private void LoadMenuItems(string category)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT productName, Price, currentstock FROM productsTBL";
                if (category != "All")
                {
                    query += " WHERE Category = @Category";
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
                        dgvMenuItems.Columns["productName"].HeaderText = "Product Name";
                        dgvMenuItems.Columns["Price"].DefaultCellStyle.Format = "N2";
                        dgvMenuItems.Columns["currentstock"].HeaderText = "currentstock";
                        dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvMenuItems.ClearSelection();
                        dgvMenuItems.CurrentCell = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            lblSubtotal.Text = subtotal.ToString("N2");
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrderType.SelectedItem == null)
            {
                MessageBox.Show("Please select an Order Type (Dine In / Take Out).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvMenuItems.CurrentRow == null || dgvMenuItems.SelectedRows.Count == 0 && dgvMenuItems.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an item from Menu Items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int inputQty) || inputQty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }
            string prodName = dgvMenuItems.CurrentRow.Cells["productName"].Value.ToString();
            int stockAvailable = Convert.ToInt32(dgvMenuItems.CurrentRow.Cells["currentstock"].Value);
            if (inputQty > stockAvailable)
            {
                MessageBox.Show($"Insufficient stock! Only {stockAvailable} items left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string updateStockQuery = "UPDATE productsTBL SET currentstock = currentstock - @Qty WHERE productName = @ProductName";
                using (SqlCommand cmd = new SqlCommand(updateStockQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Qty", inputQty);
                    cmd.Parameters.AddWithValue("@ProductName", prodName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating stock in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            string orderType = cmbOrderType.SelectedItem.ToString();
            double price = Convert.ToDouble(dgvMenuItems.CurrentRow.Cells["Price"].Value);
            double total = price * inputQty;
            dgvCurrentOrder.Rows.Add(orderType, prodName, price, inputQty, total);
            if (rbAll.Checked) LoadMenuItems("All");
            else if (rbWings.Checked) LoadMenuItems("Wings");
            else if (rbRicePlatter.Checked) LoadMenuItems("Rice Platter");
            else if (rbDrinks.Checked) LoadMenuItems("Drinks");
            UpdateSubtotal();
            txtQuantity.Clear();
            txtQuantity.Enabled = false;
            btnAddToOrder.Enabled = false;
            dgvMenuItems.ClearSelection();
            dgvMenuItems.CurrentCell = null;
            dgvCurrentOrder.ClearSelection();
            dgvCurrentOrder.CurrentCell = null;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.CurrentRow != null && dgvCurrentOrder.SelectedRows.Count > 0 && !dgvCurrentOrder.CurrentRow.IsNewRow)
            {
                string prodName = dgvCurrentOrder.CurrentRow.Cells["ProductName"].Value.ToString();
                int qtyToReturn = Convert.ToInt32(dgvCurrentOrder.CurrentRow.Cells["Quantity"].Value);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string returnStockQuery = "UPDATE productsTBL SET currentstock = currentstock + @Qty WHERE productName = @ProductName";
                    using (SqlCommand cmd = new SqlCommand(returnStockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qtyToReturn);
                        cmd.Parameters.AddWithValue("@ProductName", prodName);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error restoring stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                dgvCurrentOrder.Rows.Remove(dgvCurrentOrder.CurrentRow);
                if (rbAll.Checked) LoadMenuItems("All");
                else if (rbWings.Checked) LoadMenuItems("Wings");
                else if (rbRicePlatter.Checked) LoadMenuItems("Rice Platter");
                else if (rbDrinks.Checked) LoadMenuItems("Drinks");
                UpdateSubtotal();
                dgvCurrentOrder.ClearSelection();
                dgvCurrentOrder.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("Please select an item from Current Order to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbWings_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbWings.Checked) LoadMenuItems("Wings");
        }

        private void rbRicePlatter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbRicePlatter.Checked) LoadMenuItems("Rice Platter");
        }

        private void rbDrinks_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDrinks.Checked) LoadMenuItems("Drinks");
        }

        private void rbAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAll.Checked) LoadMenuItems("All");
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.Rows.Count == 0)
            {
                MessageBox.Show("The order list is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbOrderType.SelectedItem == null)
            {
                MessageBox.Show("Please select an Order Type before checking out.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // INAYOS DITO: Kinuha ang string value ng lblSubtotal, tinanggal ang peso sign o spaces para hindi mag-crash
            string cleanSubtotalText = lblSubtotal.Text.Replace("₱", "").Replace("PHP", "").Replace(" ", "").Trim();

            // Gumamit ng double.TryParse para kung may error man sa format, gagawin lang itong 0.00 imbis na mag-crash ang buong runtime
            if (!double.TryParse(cleanSubtotalText, out double currentSubtotal))
            {
                currentSubtotal = 0.00;
            }

            string selectedOrderType = cmbOrderType.SelectedItem.ToString();
            int generatedOrderID = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO ordersTBL (orderType, paymentMethod) VALUES (@orderType, 'Pending');
                                 SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderType", selectedOrderType);
                    try
                    {
                        conn.Open();
                        generatedOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating Order Number:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            PaymentForm payment = new PaymentForm(currentSubtotal, selectedOrderType, generatedOrderID);
            if (payment.ShowDialog() == DialogResult.OK)
            {
                dgvCurrentOrder.Rows.Clear();
                lblSubtotal.Text = "0.00";
                cmbOrderType.SelectedIndex = -1;
            }
        }

        private void dgvMenuItems_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMenuItems.Rows[e.RowIndex].Cells["productName"].Value != null)
            {
                txtQuantity.Enabled = true;
                btnAddToOrder.Enabled = true;
                txtQuantity.Focus();
            }
        }

        private void dgvCurrentOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMenuItems.Rows[e.RowIndex].Cells["productName"].Value != null)
            {
                txtQuantity.Enabled = true;
                btnAddToOrder.Enabled = true;
                txtQuantity.Focus();
            }
        }

        private void Sales_Order_Module_Load(object sender, EventArgs e)
        {
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.CurrentRow != null && dgvCurrentOrder.SelectedRows.Count > 0 && !dgvCurrentOrder.CurrentRow.IsNewRow)
            {
                string prodName = dgvCurrentOrder.CurrentRow.Cells["ProductName"].Value.ToString();
                int qtyToReturn = Convert.ToInt32(dgvCurrentOrder.CurrentRow.Cells["Quantity"].Value);
                double itemTotal = Convert.ToDouble(dgvCurrentOrder.CurrentRow.Cells["Total"].Value);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string returnStockQuery = "UPDATE productsTBL SET currentstock = currentstock + @Qty WHERE productName = @ProductName";
                    using (SqlCommand cmd = new SqlCommand(returnStockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qtyToReturn);
                        cmd.Parameters.AddWithValue("@ProductName", prodName);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error restoring stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                dgvCurrentOrder.Rows.Remove(dgvCurrentOrder.CurrentRow);
                if (rbAll.Checked) LoadMenuItems("All");
                else if (rbWings.Checked) LoadMenuItems("Wings");
                else if (rbRicePlatter.Checked) LoadMenuItems("Rice Platter");
                else if (rbDrinks.Checked) LoadMenuItems("Drinks");

                double currentSubtotal = Convert.ToDouble(lblSubtotal.Text);
                double newSubtotal = currentSubtotal - itemTotal;
                lblSubtotal.Text = newSubtotal.ToString("N2");

                dgvCurrentOrder.ClearSelection();
                dgvCurrentOrder.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("Please select an item from Current Order to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}