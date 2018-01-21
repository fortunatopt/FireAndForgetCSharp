using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAndForget
{
    class Program
    {
        public static void Sum(int sleepTime, int numA, int numB)
        {
            System.Threading.Thread.Sleep(sleepTime * 1000);
            int sum = numA + numB;
            Console.WriteLine($"The sum of {numA} plus {numB} is {sum}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seconds to wait");
            int sleep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first value to add");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first value to add");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Task.Factory.StartNew(() => Sum(sleep, num1, num2));
            Console.WriteLine($"This line is called after the Add() method. You are waiting for {sleep} second{(sleep == 1 ? "" : "s")}");
            Console.ReadKey();
        }
    }
}
