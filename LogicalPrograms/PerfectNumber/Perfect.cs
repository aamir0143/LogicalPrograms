using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.PerfectNumber 
{
    public class Perfect
    {
        public static void PerfectNumber() 
        {
            int sum = 0;
            Console.Write("\tEnter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.WriteLine("\t{0} ", i);
                }
            }
            if (sum == num)
            {
                Console.WriteLine("\tis a Perfect number"+num);
            }
            else
            {
                Console.WriteLine("\tis not a Perfect number"+num);
            }
            Console.WriteLine("==========================================================================");
        }
    }
}
