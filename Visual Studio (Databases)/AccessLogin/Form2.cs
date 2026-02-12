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

namespace AccessLogin
{
    public partial class Form2 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CLIENT\Downloads\Database2.mdb;
Persist Security Info=False;";
            groupBox2.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtLastName.TextChanged += new EventHandler(CheckGroupBox1Fields);
            txtFirstName.TextChanged += new EventHandler(CheckGroupBox1Fields);
            txtGender.TextChanged += new EventHandler(CheckGroupBox1Fields);
            dateTimePicker1.ValueChanged += new EventHandler(CheckGroupBox1Fields);
        }
        private void CheckGroupBox1Fields(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtGender.Text) &&
                 dateTimePicker1.Value.Date != DateTime.Today)
            {
             
                groupBox2.Enabled = true;
            }
            else
            {
            
                groupBox2.Enabled = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == txtConfirm.Text)
            {
                try
                {
                    connect.Open();

                  
                    OleDbCommand checkCommand = new OleDbCommand();
                    checkCommand.Connection = connect;
                    checkCommand.CommandText = "SELECT COUNT(*) FROM [Student info] WHERE [Username] = ? OR [Password] = ?";
                    checkCommand.Parameters.AddWithValue("?", txtUsername.Text);
                    checkCommand.Parameters.AddWithValue("?", txtPassword.Text);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0) 
                    {
                        MessageBox.Show("Oops! The username or password you entered is already in use. Pick a different one");
                    }
                    else
                    {
                    
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connect;
                        command.CommandText = "INSERT INTO [Student info] ([Last Name], [First Name], [Gender], [Birthday], [Username], [Password]) " +
                                              "VALUES (?, ?, ?, ?, ?, ?)";
                        command.Parameters.AddWithValue("?", txtLastName.Text);
                        command.Parameters.AddWithValue("?", txtFirstName.Text);
                        command.Parameters.AddWithValue("?", txtGender.Text);
                        command.Parameters.AddWithValue("?", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("?", txtUsername.Text);
                        command.Parameters.AddWithValue("?", txtPassword.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful");

                        connect.Close();
                        this.Close();

                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close(); 
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtGender.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
        }
    }
}
