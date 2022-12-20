using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__perfect_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2, i, sum ,j;
            Console.WriteLine("Enter The Range From n1 To n2");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            
            


                for (i = n1; i <= n2; i++)
                {
                sum = 0;
                   for (j = 1; j < i; j++)
                   {
                        if (i % j == 0)
                        sum = sum + j;
                   }
                   if (sum == i)
                     Console.WriteLine(i);
                } 
                
               
            
                Console.ReadKey();
            
        }


    }
}
