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

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            float x, y;
            Calcalator c = new Calcalator();
            string options = @"1. Add
2. Subtract
3. Multiply
4. Divide";
            while (input != 0)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine(options);
                input = Int16.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("What is your X value?");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("What is your y value?");
                        y = float.Parse(Console.ReadLine());
                        Console.WriteLine(c.add(x, y));
                        break;
                    case 2:
                        Console.WriteLine("What is your X value?");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("What is your y value?");
                        y = float.Parse(Console.ReadLine());
                        Console.WriteLine(c.subtract(x, y));
                        break;
                    case 3:
                        Console.WriteLine("What is your X value?");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("What is your y value?");
                        y = float.Parse(Console.ReadLine());
                        Console.WriteLine(c.multiply(x, y));
                        break;
                    case 4:
                        Console.WriteLine("What is your X value?");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("What is your y value?");
                        y = float.Parse(Console.ReadLine());
                        Console.WriteLine(c.divide(x, y));
                        break;
                }
                Console.WriteLine(" ");
            }
        }
    }

    public interface CalcOp
    {
        public float add(float x, float y);
        public float subtract(float x, float y);
        public float multiply(float x, float y);
        public float divide(float x, float y);
    }


    public class Calcalator : CalcOp
    {
        public float add(float x, float y)
        {
            return x + y;
        }
        public float subtract(float x, float y)
        {
            return x - y;
        }
        public float multiply(float x, float y)
        {
            return x * y;
        }
        public float divide(float x, float y)
        {
            return x / y;
        }
    }
}
