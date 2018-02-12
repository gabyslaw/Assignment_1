using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Maths
    {

        public void Add(double x, double y)
        {
            Console.WriteLine($"The addition of {x} and {y} is, {x + y} ");
        }

        public void Subtract(double x, double y)
        {
            Console.WriteLine($"The subtraction of {x} and {y} is, {x - y} ");
        }

        public void Multiply(double x, double y)
        {
            Console.WriteLine($"The multiplication of {x} and {y} is, {x * y} ");
        }

        public void Divide(double x, double y)
        {
            Console.WriteLine($"The division of {x} and {y} is, {x / y} ");
        }

    }
}
