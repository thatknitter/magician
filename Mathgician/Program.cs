﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok. I'm gonna do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            } else if ("Fibonacci" == desiredMaths) {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            }
            else
            {
                Console.WriteLine("Well, actually... I Lied...");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void PrintPrimes()
        {
            var array = new[] { 2 };
            var list = new LinkedList<int>(array);
            int checkNum = 1;
            while (true) 
            { 
                foreach (int integer in list)
                {
                    if (checkNum % integer == 0)
                    {
                        checkNum += 2;
                    }
                    else
                    {
                        Console.WriteLine(checkNum);
                        list.AddLast(checkNum);
                        checkNum += 2;
                    }
                }
            }
        }

        private static void PrintFibonacciSequence()
        {
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while(true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}
