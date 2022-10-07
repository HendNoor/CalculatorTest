// See https://aka.ms/new-console-template for more information
using System;

namespace CalcolatorTest
{

    public class Test
    {

        public static double Addition(double num1, double num2)
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
        public static double Subtraction(double num1, double num2)
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
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
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
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Select an option to start: ");
                Console.WriteLine("\n1. For adding two numbers \n2. For dding more then two numbers \n3. For subtracting two numbers \n4. For subtracting more then two numbers \n5. For Multiplication \n6. For division");
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = (int)Addition(num1, num2);
                        Console.WriteLine($"The Result : {num1} + {num2} = " + result);
                        break;
                    case 2:
                        Console.WriteLine("how many numbers you want to:");
                        int count = int.Parse(Console.ReadLine());
                        int[] arr = new int[count]; for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("number {0}:", i + 1);
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        result = (int)Addition(arr);
                        Console.WriteLine("The result is :{0}", result);
                        break;
                    case 3:
                        Console.Write("Enter a number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = (int)Subtraction(num1, num2);
                        Console.WriteLine($"The result of {num1} - {num2} = " + result);
                        break;


                    case 4:
                        Console.WriteLine("how many numbers you want to:");
                        int count1 = int.Parse(Console.ReadLine());
                        int[] arr1 = new int[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            Console.WriteLine("number {0}:", i + 1);
                            arr1[i] = int.Parse(Console.ReadLine());
                        }
                        result = (int)Subtraction(arr1);
                        Console.WriteLine("The result is :{0}", result);
                        break;
                    case 5:
                        Console.Write("Enter a number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = (int)Multiplication(num1, num2);
                        Console.WriteLine($"The result of {num1} * {num2} = " + result);
                        break;
                    case 6:
                        Console.Write("Enter a number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number: ");
                        num2 = int.Parse(Console.ReadLine());
                        if (num2 != 0) try
                            {
                                result = (int)Division(num1, num2);
                                Console.WriteLine($"The result of {num1} / {num2} = " + result);
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine();
                            }
                        else
                        {
                            Console.WriteLine("Error! Number can't be divided");
                        }
                        break;
                    default:
                        Console.WriteLine("The number you entered is incorrect. Please enter a correct number:");
                        break;
                }

                Console.WriteLine("Do you want to continue ! Press Y = Yes  <==>  N = NO: ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

