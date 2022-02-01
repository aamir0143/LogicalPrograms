// See https://aka.ms/new-console-template for more information
using LogicalPrograms.CouponNumbers;
using LogicalPrograms.FibonacciSeries;
using LogicalPrograms.PerfectNumber;
using LogicalPrograms.PrimeNumbers;
using LogicalPrograms.ReverseNumber;
using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Logical Programs==========");
            Console.WriteLine();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Choose any option");
                    Console.WriteLine("\t1. Fibonacci Seriea");
                    Console.WriteLine("\t2. Perfect Number");
                    Console.WriteLine("\t3. Prime Numbers");
                    Console.WriteLine("\t4. Reverse Number");
                    Console.WriteLine("\t5. Coupon Numbers");
                    Console.WriteLine("\t6. Exit");
                    Console.Write("Enter Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Fibonacci Series==========");
                            Fibonacci.FibonacciSeries(); //Call the method 
                            break;
                        case 2:
                            Console.WriteLine("\n\t==========2. Perfect Number=============");
                            Perfect.PerfectNumber();
                            break;
                        case 3:
                            Console.WriteLine("\n\t==========3. Prime Numbers===============");
                            Prime.PrimeNumbers();
                            break;
                        case 4:
                            Console.WriteLine("\n\t==========4. Reverse Number==============");
                            Reverse.ReverseNumber();
                            break;
                        case 5:
                            Console.WriteLine("\n\t==========5. Coupon Numbers==============");
                            Console.Write("\tHow many numbers you wants to generate: ");
                            int N = Convert.ToInt32(Console.ReadLine());
                            Coupon.CouponNumber(N);
                            break;
                        case 6:
                        default:
                            flag = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid Input");
                }
            }

        }
    }
}
