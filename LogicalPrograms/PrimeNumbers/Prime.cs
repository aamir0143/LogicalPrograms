using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.PrimeNumbers
{
    public class Prime
    {
        public static void PrimeNumbers()
        {
            Console.Write("\tEnter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("\tis a Prime number"+num);
            }
            else
            {
                Console.WriteLine("\tis not a Prime number"+num);
            }
            Console.WriteLine("==========================================================================");
        }
    }
}
