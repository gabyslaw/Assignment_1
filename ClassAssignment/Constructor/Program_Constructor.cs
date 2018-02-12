using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.Constructor

{
    class Program
    {
        static double firstValue, secondValue;
        
        static void Main()
        {

            Console.WriteLine("Welcome to the simple calculator machine!");
            label:
            Console.WriteLine("Please enter \n 1 for Addition \n 2 for Subtraction \n 3 for Multiplication" +
                " \n 4 for Division");
            var reply = double.Parse(Console.ReadLine());
            Maths cal = new Maths(firstValue, secondValue);
            if (reply == 1)
            {
                Console.Clear();
                RequestInput();
                cal.Add();
            }
            else if (reply == 2)
            {
                Console.Clear();
                RequestInput();
                cal.Subtract();
            }
            else if (reply == 3)
            {
                Console.Clear();
                RequestInput();
                cal.Multiply();
            }
            else if (reply == 4)
            {
                Console.Clear();
                RequestInput();
                cal.Divide();
            }
            else
            {
                goto label;
            }
            Console.ReadLine();

        }

        private static void RequestInput()
        {
            Console.Write("Please enter the first value:");
            firstValue = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second value:");
            secondValue = double.Parse(Console.ReadLine());
           
        }

        
        
    }
}
