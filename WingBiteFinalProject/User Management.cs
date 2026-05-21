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
        private string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false";

        public void UserManagementForm()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            string query = "SELECT userID, Fullname, username, Role, UserStatus, CreatedDate FROM UserTBL";

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
                MessageBox.Show("Failed to load user list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
        string.IsNullOrEmpty(txtFullName.Text) || cmbRole.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields before adding a new user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pwd = txtPassword.Text;

            if (pwd.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Password Policy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!char.IsUpper(pwd[0]))
            {
                MessageBox.Show("Password must start with a capital letter (A-Z).", "Password Policy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(pwd, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Password must contain at least one special character (e.g., !, @, #, $, %).", "Password Policy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false;";
            string query = @"INSERT INTO UserTBL (Fullname, username, password, Role, UserStatus) 
                     VALUES (@Fullname, @Username, @Password, @Role, @Status)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Fullname", SqlDbType.VarChar, 100).Value = txtFullName.Text.Trim();
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = txtUsername.Text.Trim();
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar, 200).Value = pwd;
                        cmd.Parameters.Add("@Role", SqlDbType.VarChar, 100).Value = cmbRole.Text;
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar, 100).Value = cmbStatus.Text;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New user successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadUserData();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("The username already exists. Please choose a unique username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please select or specify the Username of the record you want to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false;";
            string query = @"UPDATE UserTBL 
                     SET Fullname = @Fullname, Role = @Role, UserStatus = @Status 
                     WHERE username = @Username";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Fullname", SqlDbType.VarChar, 100).Value = txtFullName.Text.Trim();
                        cmd.Parameters.Add("@Role", SqlDbType.VarChar, 100).Value = cmbRole.Text;
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar, 100).Value = cmbStatus.Text;
                        cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = txtUsername.Text.Trim();

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No user found with that username.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a full row from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedUsername = dgvUsers.SelectedRows[0].Cells["username"].Value.ToString();

            if (selectedUsername.ToLower() == "admin")
            {
                MessageBox.Show("You cannot delete the primary Admin account!", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete user '{selectedUsername}'?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false;";
                string query = "DELETE FROM UserTBL WHERE username = @Username";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = selectedUsername;

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadUserData();
                                ClearFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Page main = new Main_Page();
            main.Show();
            this.Hide();

        }
    }
    }
    
    
    

