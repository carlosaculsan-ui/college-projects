using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Activity_10
{
    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\OneDrive\Documents\SDF104.mdb;Persist Security Info=False;";
        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = connectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT FirstName, LastName, Contact, Address FROM Users", connect))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsers.SelectedRows[0];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                richTextAddress.Text = row.Cells["Address"].Value.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Users (FirstName, LastName, Contact, Address) " +
                               "VALUES (@FirstName, @LastName, @Contact, @Address)";

                using (OleDbCommand command = new OleDbCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@Contact", txtContact.Text);
                    command.Parameters.AddWithValue("@Address", richTextAddress.Text);

                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("User information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    string firstName = dgvUsers.SelectedRows[0].Cells["FirstName"].Value.ToString();
                    string lastName = dgvUsers.SelectedRows[0].Cells["LastName"].Value.ToString();

                    string query = "DELETE FROM Users WHERE FirstName = @FirstName AND LastName = @LastName";

                    using (OleDbCommand command = new OleDbCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);

                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataIntoDataGridView(); 
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            richTextAddress.Clear();
        }
    }
}
