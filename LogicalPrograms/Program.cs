// See https://aka.ms/new-console-template for more information
using LogicalPrograms.FibonacciSeries; 
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
                    Console.WriteLine("\t2. Exit");
                    Console.Write("Enter Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t========== 1. Fibonacci Series==========");
                            Fibonacci.FibonacciSeries(); //Call the method 
                            break;
                        case 2:
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
