using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator aCalculator = new Calculator();
        private double firstNumber;
        private double secondNumber;

        private void addButton_Click(object sender, EventArgs e)
        {
            GetInitialFirstandSecondNumberValue();
            double result= aCalculator.Add(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();

        }

        private void GetInitialFirstandSecondNumberValue()
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            GetInitialFirstandSecondNumberValue();
            double result = aCalculator.Substract(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            GetInitialFirstandSecondNumberValue();
            double result = aCalculator.Multiply(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            GetInitialFirstandSecondNumberValue();
            double result = aCalculator.Devide(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }
    }
}
