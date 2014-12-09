using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalculationApp
{
    class Number
    {
        public int firstNumber;
        public int secondNumber;
        public int result;

        public int Add( int firstNumber , int secondNumber )
        {
            return  firstNumber + secondNumber;
             
        }

        public int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;

        }

        public int Devide(int firstNumber, int secondNumber)
        {
            return firstNumber/secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber*secondNumber;
        }
    }
}
