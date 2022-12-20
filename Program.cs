using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1__Prime_Number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j;
            Console.WriteLine("Enter The Range From n1 To n2");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            for (i = n1; i < n2; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;

                    }

                }
                if (i == j)
                    Console.WriteLine(i);
            }
        }
    }
}
