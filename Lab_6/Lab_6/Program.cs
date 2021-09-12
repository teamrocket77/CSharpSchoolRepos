/*
 * Student: Vincent Cradler
 * Date: 08292021
 * Class: CSE 1322L 
 * section: #02
 * 
 * Assignment: {Lab 3} Change Me!
 * Instructor: Kavitha
 */
using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FibIteration iter = new FibIteration();
            FibFormula form  = new FibFormula();
            Console.WriteLine(iter.calculate_fib(10));
            Console.WriteLine(form.calculate_fib(10));
        }
    }

    public interface FindFib
    {
        public int calculate_fib(int num);

    }

    public class FibIteration : FindFib
    {
        public int calculate_fib(int num)
        {
            if (num == 1 || num ==2) return 1;
            return calculate_fib(num - 1) + calculate_fib(num - 2);

        }
    }


    public class FibFormula : FindFib
    {
        public int calculate_fib(int num)
        {
            var x = (Math.Pow((1 + Math.Sqrt(5)) / 2, num) - Math.Pow((1 - Math.Sqrt(5)) / 2, num)) / Math.Sqrt(5);
            return (int)Math.Round(x, 0);
        }
    }
}
