using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUI
{
    public partial class BankUI : Form
    {
        public BankUI()
        {
            InitializeComponent();
        }

        private Customer aCustomer;

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account anAccount = new Account(accountNumberEntryTextBox.Text, openingDateEntryTextBox.Text);
            aCustomer = new Customer(customerNameEntryTextBox.Text, emailEntryTextBox.Text);
            aCustomer.AnAccount = anAccount;
            MessageBox.Show("Account Created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            string msg = aCustomer.AnAccount.Deposit(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show(msg);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string msg = aCustomer.AnAccount.Withdraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show(msg);
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountNumberDisplayTextBox.Text = aCustomer.AnAccount.AccountNo;
            openingDateDisplayTextBox.Text = aCustomer.AnAccount.OpeningDate;
            balanceTextBox.Text = aCustomer.AnAccount.Balance.ToString();
        }
    }
}
