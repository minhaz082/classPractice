using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeed
{
    public partial class VehicleSpeed : Form
    {
        public VehicleSpeed()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.HelloSet("abd");
            aVehicle.HelloGet();

            aVehicle = new Vehicle();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.enterSpeed(Convert.ToDouble(speedTextBox.Text));
            MessageBox.Show("Speed Inserted");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.minSpeedCal().ToString();
            maxSpeedTextBox.Text = aVehicle.maxSpeedCal().ToString();
            avgSpeedTextBox.Text = aVehicle.avgSpeedCal().ToString();
        }
    }
}
