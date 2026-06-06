
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace WingBiteFinalProject
{
    public partial class LoginForm : Form
    {
        public static string CurrentUserID = string.Empty;
        public static string CurrentUserFullName = string.Empty;
        public static string CurrentUserRole = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text.Trim();
            string inputPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both Username and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // dito mag base kayo sa ssms nyo, palitan ang server name.
            string connString = "Server=YJAIXX_COLIE\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";

            string query = @"SELECT userID, Fullname, Role FROM UserTBL 
                             WHERE username = @User 
                             AND password COLLATE Latin1_General_BIN = @Pass 
                             AND UserStatus = 'Active'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@User", SqlDbType.VarChar, 100).Value = inputUsername;
                        cmd.Parameters.Add("@Pass", SqlDbType.VarChar, 200).Value = inputPassword;

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())


                            if (reader.Read())
                            {
                                CurrentUserID = reader["userID"].ToString();
                                CurrentUserFullName = reader["Fullname"].ToString();
                                CurrentUserRole = reader["Role"].ToString();
                                

                                MessageBox.Show($"Login Successful! Welcome back, {CurrentUserFullName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Main_Page main = new Main_Page();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Kung walang nahanap na record (maling password, maling username, o kaya Inactive ang account)
                                MessageBox.Show("Invalid Username or Password, or account is Inactive.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }
    }
}
    

