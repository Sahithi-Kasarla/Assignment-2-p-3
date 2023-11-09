using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_p_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int n = 10;  // Number of Fibonacci numbers to print
             int a = 0;
             int b = 1;

             Console.WriteLine("First 10 numbers in the Fibonacci sequence:");

             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine(a);

                 int temp = a + b;  // Update the values for the next iteration
                 a = b;
                 b = temp;
                 Console.ReadKey();
             }
            */

            int[] array = new int[5];
            // Populate the array with random integer values
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);  // Generate random integers between 1 and 100
            }
            //Display the array
            Console.WriteLine("Array elements:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //calculate the sum
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
               sum = sum + array[i];
            }
            Console.WriteLine("sum of elements "+sum);
            //calculate the vaerage
            double average = (double)sum / array.Length;
            Console.WriteLine("Average of elements: " + average);

            Console.ReadKey();
        }
    }
}

