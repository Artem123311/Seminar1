using System;
using System.Diagnostics;
 
namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Max digit is: " + GetMaxDigit(n));
 
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
 
            for (int i = 0; i < 1000000; i++)
                GetMaxDigit(n);
 
            stopWatch.Stop();
 
            Console.WriteLine("Elapsed time (ms): " + stopWatch.ElapsedMilliseconds);
        }
 
        static int GetMaxDigit(int n)
        {
            int max = Int32.MinValue;
 
            while (n != 0)
            {
                int digit = n % 10;
                if (digit > max)
                    max = digit;
                n /= 10;
            }
 
            return max;
        }
    }
}