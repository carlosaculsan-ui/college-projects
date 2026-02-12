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

    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\CLIENT\Downloads\Database2.mdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {



                connect.Open();
                label1.Text = "";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;

        
                command.CommandText = "SELECT [First Name], [Last Name] FROM [Student info] WHERE [Username] = ? AND [Password] = ?";
                command.Parameters.AddWithValue("?", textBox1.Text);  
                command.Parameters.AddWithValue("?", textBox2.Text);  

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                string firstName = "";
                string lastName = "";

           
                while (reader.Read())
                {
                    count++;
                    firstName = reader["First Name"].ToString(); 
                    lastName = reader["Last Name"].ToString();   
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and password are correct.");

                    this.Hide();
                  
                    Form3 f3 = new Form3(firstName, lastName);
                    f3.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password.");
                }
                else
                {
                    MessageBox.Show("Incorrect Username and password.");
                }

                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}

