using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeApp
{
    public partial class ResumeUI : Form
    {
        public ResumeUI()
        {
            InitializeComponent();
        }

        private Person aPerson;
        private Degree aDegree;
        private Experience anExperience;

        private void personalSaveButton_Click(object sender, EventArgs e)
        {
            
            aPerson = new Person(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text), countryTextBox.Text, emailTextBox.Text, aDegree, anExperience);
            MessageBox.Show("Person Created");
            
        }

        private void degreeSaveButton_Click(object sender, EventArgs e)
        {
            aDegree = new Degree(instituteNameTextBox.Text, instituteCountryTextBox.Text);
            MessageBox.Show("Degree Assigned");
        }

        private void experienceSaveButton_Click(object sender, EventArgs e)
        {
            anExperience = new Experience(majorExperienceTextBox.Text, Convert.ToInt32(experienceYearTextBox.Text));
            MessageBox.Show("Got Experience");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aPerson.ADegree = aDegree;
            aPerson.AnExperience = anExperience;

            nameShowTextBox.Text = aPerson.Name;
            emailShowTextBox.Text = aPerson.Email;
            ageShowTextBox.Text = aPerson.Age.ToString();
            experienceShowTextBox.Text = aPerson.CalculateExperienceYear().ToString();

            if (aPerson.CompareCountry())
            {
                yesRadioButton.Checked = true;
            }
            else
            {
                noRadioButton.Checked = true;
            }

        }
    }
}
