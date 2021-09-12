using System;

class Stuff
{
    public static int x = 7;

    public static void do_stuff()
    {
        x++;
        Console.WriteLine(x);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Stuff.do_stuff();
    }
}