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

namespace Activity_7
{
    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\OneDrive\Documents\SDF104.mdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
             private void LoadData()
        {
            try
            {
                
                string query = "SELECT FirstName, LastName, Contact, Address, Username, Password FROM Users";

               
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connect);
                DataTable dataTable = new DataTable();

               
                connect.Open();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
