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

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.Name = nameTextBox.Text;
           // aStudent.Id = Convert.ToInt32(idTextBox.Text);
            aStudent.Address = addressTextBox.Text;
            aStudent.Phone = phoneTextBox.Text;

//Connection String
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentDb45;Integrated Security=True;Pooling=False";
            SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();
            
            //ConnectionState connectionState = connection.State;
            //MessageBox.Show(connectionState.ToString());
            //create query

            string query = "Insert into Course values('" + aStudent.Name + "','" +
                                                          aStudent.Address + "','" +
                                                          aStudent.Phone + "')";
            SqlCommand command = new SqlCommand(query, connection);
            //command.ExecuteNonQuery();
            

        }
    }
}
