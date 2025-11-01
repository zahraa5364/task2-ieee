using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_ieee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int largest = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("The largest number is: " + largest);

        }
    }
}
