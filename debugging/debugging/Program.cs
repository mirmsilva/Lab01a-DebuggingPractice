using System;
using System.Linq;

namespace debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {
            Console.WriteLine(" Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[num];
            int[] populated = Populate(userArray);
            int summed = GetSum(populated);
            int product = GetProduct(userArray, summed);
            GetQuotient(product);
        }
        static int[] Populate (int[] array)
        {
            Console.WriteLine("Please enter a number greater than zero");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[array.Length];
            try
            {
                for (int i = 0; i < userArray.Length; i++)
                {
                    userArray[i] = num;
                    num = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch
            {
                Console.WriteLine("please enter a valid number");
                StartSequence();
            }
            return userArray;
        }
        static int GetSum(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine(sum);
            return sum;
        }
        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Please select a number between 1-6");
            int mult = Convert.ToInt32(Console.ReadLine());
            int product = sum * array[mult];
            return product;
        }
        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Please enter a number");
                int divider = Convert.ToInt32(Console.ReadLine());
                decimal quotient = product / divider;
                return quotient;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0");
                return 0;
            }
        }
    }
}
