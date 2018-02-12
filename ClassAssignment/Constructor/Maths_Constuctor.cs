using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.Constructor
{
    class Maths
    {
        private double firstValue, secondValue;
        public Maths(double x, double y)
        {
            firstValue = x;
            secondValue = y;
       
        }
        public void Add()
        {
            Console.WriteLine($"The addition of {firstValue} and {secondValue} is, {firstValue + secondValue} ");
        }

        public void Subtract()
        {
            Console.WriteLine($"The subtraction of {firstValue} and {secondValue} is, {firstValue + secondValue} ");
        }

        public void Multiply()
        {
            Console.WriteLine($"The multiplication of {firstValue} and {secondValue} is, {firstValue + secondValue} ");
        }

        public void Divide()
        {
            Console.WriteLine($"The division of {firstValue} and {secondValue} is, {firstValue + secondValue} ");
        }

    }
}
