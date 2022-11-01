using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9,6,4,5,1};
            int max = arr[0];
            int min = arr[1];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }

                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(max != arr[i] && min != arr[i])
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Answer: "+ sum);

        }
    }
}
