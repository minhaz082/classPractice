using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Salary aSalary = new Salary();
        private void showButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && basicTextBox.Text != "" && houseTextBox.Text != "" )
            {
                aSalary.empName = nameTextBox.Text;
                aSalary.basicAmount = Convert.ToDouble(basicTextBox.Text);
                aSalary.houseRent = Convert.ToDouble(houseTextBox.Text);
                aSalary.medicalAllowance = Convert.ToDouble(medicalTextBox.Text);
                string total = aSalary.CalculateSalary().ToString();
                string msg = aSalary.empName + " your salary is : " + total;
                MessageBox.Show(msg);
            }
            


        }
    }
}
