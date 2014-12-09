using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentStudentApp
{
    public partial class DepartmentStudentUI : Form
    {
        private Department aDepartment;
        private Student aStudent;

        public DepartmentStudentUI()
        {
            InitializeComponent();
        }

        private void saveDeptButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(codeTextBox.Text,nameTextBox.Text);
            MessageBox.Show("Department Created");
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student(regTextBox.Text,nameStudentTextBox.Text,emailTextBox.Text);
            string msg = aDepartment.AddStudent(aStudent);
            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of Students " + aDepartment.Students.Count);
        }
    }
}
