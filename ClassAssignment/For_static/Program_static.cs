using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.For_static
{
    class Program_static
    {
        static double firstValue, secondValue;

        private static void Main(String[] args)
        {

           
            label:
            Console.WriteLine("Welcome to the Calculator Options Selector page. Press an option to continue. ");
            Console.WriteLine("1) Addition ");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication ");
            Console.WriteLine("4) Division");
            Console.WriteLine("******************************************************");

         
            var reply = double.Parse(Console.ReadLine());
            
            if (reply == 1)
            {
                Console.Clear();
                RequestInput();
                Maths_static.Add(firstValue, secondValue);
            }
            else if (reply == 2)
            {
                Console.Clear();
                RequestInput();
                Maths_static.Subtract(firstValue, secondValue);
            }
            else if (reply == 3)
            {
                Console.Clear();
                RequestInput();
                Maths_static.Multiply(firstValue, secondValue);
            }
            else if (reply == 4)
            {
                Console.Clear();
                RequestInput();
                Maths_static.Divide(firstValue, secondValue);
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
