using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class Methods
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Addition(int[] numbers)
        {
            double arr = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                arr += numbers[i];
            }
            return arr;
        }


        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Subtraction(int[] numbers)
        {
            double arr = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                arr -= numbers[i];
            }
            return arr;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static decimal? Division(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
                Console.WriteLine();
                return result;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Error! Number can't be divided");
                return null;

            }
        }
    }
}

