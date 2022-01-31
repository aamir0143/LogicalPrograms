using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.FibonacciSeries 
{
    public class Fibonacci
    {
        public static void FibonacciSeries() 
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.Write("\tEnter the number of Element: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine(n1);
                return;
            }
            Console.WriteLine("\t"+ n1);
            Console.WriteLine("\t"+n2);
            for (i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine("\t"+n3);
            }
            Console.WriteLine("===========================================================================");
            Console.ReadLine();
        }
    }
}
