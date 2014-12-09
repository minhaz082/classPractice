using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
              Circle acircle = new Circle();
            Console.Write("Input Radious Value");
            acircle .radious = Convert.ToDouble(Console.ReadLine());

            Console .WriteLine("Area is : " + acircle.GetArea(acircle.radious));
            Console.ReadKey();
        }
    }
}
