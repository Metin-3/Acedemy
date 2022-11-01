using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1, 6, 8, 4, 3, 9, 5};

            for (int i = 0; i <= num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Number: "+ (num[i] + 4));
                }
            }
        }
    }
}
