using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WingBiteFinalProject;

namespace WingBiteFinalProject
{
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private Menu_or_Product_Module _mainForm;

        // Baguhin ang Constructor para tanggapin ang Main Form reference
        public Add_Product(Menu_or_Product_Module mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private bool DoesInventoryIDExist(int id)
        {
            string checkQuery = "SELECT COUNT(1) FROM inventoryTBL WHERE inventoryID = @ID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(checkQuery, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu_or_Product_Module menuForm = new Menu_or_Product_Module();
            menuForm.ShowDialog();
            this.Hide();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text.Trim()) || cmbCategory.SelectedItem == null || string.IsNullOrEmpty(txtUnit.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text.Trim()) || string.IsNullOrEmpty(txtInventoryID.Text.Trim()))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!int.TryParse(txtInventoryID.Text.Trim(), out int inventoryID))
            {
                MessageBox.Show("Invalid Inventory ID.");
                return;
            }

            int qtyToDeduct = int.Parse(txtUnit.Text.Trim());
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string checkQuery = "SELECT currentstock, category FROM inventoryTBL WHERE inventoryID = @ID";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, conn, transaction);
                    cmdCheck.Parameters.AddWithValue("@ID", inventoryID);

                    using (SqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Inventory ID does not exist.");
                            reader.Close();
                            transaction.Rollback();
                            return;
                        }

                        int currentStock = Convert.ToInt32(reader["currentstock"]);
                        string invCategory = reader["category"].ToString();
                        reader.Close();

                        if (invCategory != selectedCategory)
                        {
                            MessageBox.Show("Category mismatch.");
                            transaction.Rollback();
                            return;
                        }
                        if (currentStock < qtyToDeduct)
                        {
                            MessageBox.Show("Insufficient stock.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    string checkDup = "SELECT COUNT(1) FROM productsTBL WHERE InventoryID = @ID";
                    SqlCommand cmdDup = new SqlCommand(checkDup, conn, transaction);
                    cmdDup.Parameters.AddWithValue("@ID", inventoryID);
                    if (Convert.ToInt32(cmdDup.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Inventory ID already exists.");
                        transaction.Rollback();
                        return;
                    }

                    string checkNameQuery = "SELECT COUNT(1) FROM productsTBL WHERE LOWER(ProductName) = @Name";
                    SqlCommand cmdCheckName = new SqlCommand(checkNameQuery, conn, transaction);
                    cmdCheckName.Parameters.AddWithValue("@Name", txtProductName.Text.Trim().ToLower());
                    if (Convert.ToInt32(cmdCheckName.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Product name already exists.");
                        transaction.Rollback();
                        return;
                    }

                    string updateInv = "UPDATE inventoryTBL SET currentstock = currentstock - @Qty WHERE inventoryID = @ID";
                    SqlCommand cmdUpd = new SqlCommand(updateInv, conn, transaction);
                    cmdUpd.Parameters.AddWithValue("@Qty", qtyToDeduct);
                    cmdUpd.Parameters.AddWithValue("@ID", inventoryID);
                    cmdUpd.ExecuteNonQuery();

                    string insertQuery = "INSERT INTO productsTBL (InventoryID, ProductName, category, currentstock, price) VALUES (@ID, @Name, @Cat, @Qty, @Price)";
                    SqlCommand cmdInsert = new SqlCommand(insertQuery, conn, transaction);
                    cmdInsert.Parameters.AddWithValue("@ID", inventoryID);
                    cmdInsert.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@Cat", selectedCategory);
                    cmdInsert.Parameters.AddWithValue("@Qty", qtyToDeduct);
                    cmdInsert.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text.Trim()));
                    cmdInsert.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Product added successfully.");

                    txtInventoryID.Clear();
                    txtProductName.Clear();
                    txtUnit.Clear();
                    txtPrice.Clear();
                    cmbCategory.SelectedIndex = -1;
                    txtInventoryID.Focus();

                    if (_mainForm != null) _mainForm.LoadAllProducts();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
      
        private void txtInventoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Pinipigilan ang "ding" sound ng Windows kapag nag-eenter
                e.SuppressKeyPress = true;

                // Inililipat ang focus sa susunod na control
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
        
            
        

       
    

