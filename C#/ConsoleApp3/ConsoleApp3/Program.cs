using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 7, 9, 24, 12, 23, 11, 8, 18 };
            int max = arr[0];
            int min = arr[1];

            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("Answer: "+ (max - min));
        }
    }
}
