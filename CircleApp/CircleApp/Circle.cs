using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radious;
        double pievalue = Math.PI;
        public double GetDiameter(double radious)
        {
            return 2*radious;
        }

        public double GetPerimeter(double radious)
        {
            return 2*radious*pievalue;
        }

        public double GetArea(double radious)
        {
            return pievalue*radious*radious;
        }
    }
}
