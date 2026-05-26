using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WingBiteFinalProject
{
    public partial class Edit_Product_Search : Form
    {
        string connString = "Server=DESKTOP-JG0361V\\SQLEXPRESS;Database=WingBiteDB;Trusted_Connection=True;Encrypt=false";
        private Menu_or_Product_Module _mainForm;
        public Edit_Product_Search(Menu_or_Product_Module mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu_or_Product_Module menu = new Menu_or_Product_Module();
            menu.Show();
            this.Hide();
        }
        private void btnFindID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            {
                MessageBox.Show("Please enter a product name to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "SELECT ProductID, ProductName, category, price, currentstock FROM productsTBL WHERE ProductName LIKE @Search";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Search", "%" + txtProductName.Text.Trim() + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading search results: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a product from the list to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgvProducts.CurrentRow.Cells["ProductID"].Value.ToString();
            string name = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            string category = dgvProducts.CurrentRow.Cells["category"].Value.ToString();
            Edit_Product_Details detailsForm = new Edit_Product_Details(_mainForm, id, name, category);
            this.Close();
            detailsForm.ShowDialog();
        }
        private void Edit_Product_Search_Load(object sender, EventArgs e)
        {
        }
    }
}