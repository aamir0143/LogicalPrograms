using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms.ReverseNumber
{
    public class Reverse
    {
        public static void ReverseNumber()
        {
            Console.Write("\tEnter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("\tThe Reverse num is : " + revNum);
            Console.WriteLine("===============================================================================");
        }
    }
}
