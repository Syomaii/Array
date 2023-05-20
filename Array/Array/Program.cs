using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        public static int ComputeSumEven(int[] array) {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int ComputeSumOdd(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for(int i = 0; i<size; i++)
            {
                Console.Write($"Enter num [{i+1}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Odd: ");
            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 != 0)
                    Console.Write($"{array[i]}, ");
            }
            Console.Write("\nEven: ");
            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write($"{array[i]}, ");
            }
            int sumOdd = ComputeSumOdd(array);
            int sumEven = ComputeSumEven(array);
            Console.WriteLine($"\nSum of all odd: {sumOdd}");
            Console.WriteLine($"Sum of all even: {sumEven}");
        }
    }
}
