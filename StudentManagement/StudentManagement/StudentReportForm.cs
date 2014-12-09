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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentDb45;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection( connectionString);
            connection.Open();
            string query = "Select * from Student";
             SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Student>studentList=new List<Student>();
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.Id = (int) reader[0];
                aStudent.Name = reader[1].ToString();
                aStudent.Address = reader[2].ToString();
                aStudent.Phone = reader[3].ToString();

                studentList.Add(aStudent);


            }
            dataGridView1.DataSource = studentList;

        }
    }
}
