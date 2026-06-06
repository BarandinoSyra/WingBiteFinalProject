using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WingBiteFinalProject
{
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
        }
        private string connString = "Server=YJAIXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

        public void UserManagementForm()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            string query = "SELECT ID, userID, Fullname, username, password, Role, UserStatus, CreatedDate FROM UserTBL";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        
                        dgvUsers.DataSource = dt;

                       
                        dgvUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load user list: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetNextUserID()
        {
            string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(userID, 4, LEN(userID)) AS INT)), 0) FROM UserTBL WHERE userID LIKE 'USR%'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    int maxNumericValue = (int)cmd.ExecuteScalar();
                    int nextNumericValue = maxNumericValue + 1;

                    
                    return $"USR{nextNumericValue:D2}";
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void btnAddNewUSer_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) || cmbRole.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all input fields first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password strings do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string query = @"INSERT INTO UserTBL (Fullname, username, password, Role, UserStatus, CreatedDate) 
                     VALUES (@Fullname, @Username, @Password, @Role, @UserStatus, GETDATE())";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Mga parameters na ipapasa sa database query
                        cmd.Parameters.AddWithValue("@Fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@UserStatus", cmbStatus.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User successfully created! The system has automatically generated a User ID.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadUserData(); 
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627) 
            {
                MessageBox.Show("That login username is already taken. Choose a different one.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 




        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please select a user from the table or provide a username to apply edits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE UserTBL 
                             SET Fullname = @Fullname, Role = @Role, UserStatus = @UserStatus 
                             WHERE username = @Username";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@UserStatus", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                        conn.Open();
                        int rowsImpacted = cmd.ExecuteNonQuery();

                        if (rowsImpacted > 0)
                        {
                            MessageBox.Show("User profiles successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No database record matched that username query.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute update: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearFields();
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFullName.Clear();
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please highlight a complete record row within the layout grid to drop.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string TargetUser = dgvUsers.SelectedRows[0].Cells["username"].Value.ToString();

            
            if (TargetUser.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Crucial system accounts like 'Admin' cannot be removed.", "Action Aborted", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult validationPrompt = MessageBox.Show($"Permanently drop database record for user '{TargetUser}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (validationPrompt == DialogResult.Yes)
            {
                string query = "DELETE FROM UserTBL WHERE username = @Username";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", TargetUser);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data row safely dropped from SSMS logging records.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                            ClearFields();
                           
                        }
                    }
                }
                catch (Exception ex)
                {


                }
            }
        }
                
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();

        }

        private void User_Management_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    
    

