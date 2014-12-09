using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeed
{
    class Vehicle
    {
        public string Hello { private set; get; }

        private string hello;

        public string Hello
        {

            get { return hello; }
        }


        public string Name { private get; set; }
        public string Reg { private get; set; }

        private List<double> speedList = new List<double>();

        public Vehicle(string name, string reg) : this(name)
        {
            Reg = reg;
        }

        public Vehicle(string rent) : this()
        {
            Name = rent;
        }

        public Vehicle()
        {
            Name = "honda";
            Reg = "reg-1";
        }

        //public Vehicle(string name, string reg) : this()
        //{
        //    Name = name;
        //    Reg = reg;
        //}

        //public Vehicle()
        //{
        //    Name = "Anonymous";
        //    Reg = "R0001";
        //}

        public void enterSpeed(double speedItem)
        {
            speedList.Add(speedItem);
        }

        public double minSpeedCal()
        {
            return speedList.Min();
        }

        public double maxSpeedCal()
        {
            return speedList.Max();
        }

        public double avgSpeedCal()
        {
            return speedList.Average();
        }

    }
}
