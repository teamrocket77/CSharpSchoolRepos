using System;

namespace Module_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] mv = new char[4, 26];
            char[,] holder;
            char[,] mirror;
            holder = make_forward();
            mirror = make_mirror(make_forward());
            int x, y, row, col;
            x = holder.GetLength(0);
            y = holder.GetLength(1);
            for (row = 0; row < x; row++)
            {
                for (col = 0; col < y; col++)
                {
                    mv[row, col] = holder[row, col];
                    System.Console.Write(holder[row, col]);

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            for (row = 0; row < x; row++)
            {
                for (col = 0; col < y; col++)
                {
                    mv[row, col + 13] = mirror[row, col];
                    System.Console.Write(mirror[row, col]);

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            for (row = 0; row < 4; row++)
            {
                for (col = 0; col < 26; col++)
                {
                    System.Console.Write(mv[row, col]);
                }
                System.Console.WriteLine(" ");
            }

        }
        public static char[,] make_mirror(char[,] char_array)
        {
            char[,] mirror = new char[4, 13];

      
            int x, y;
            for (x = 0; x < 4; x++)
            {
                for (y = 12; y >= 0; y--)
                {
                    if (char_array[x, y] == '(')
                    {
                        char_array[x, y] = ')';
                    }
                    else if (char_array[x, y] == ')')
                    {
                        char_array[x, y] = '(';
                    }
                    else if (char_array[x, y] == '/')
                    {
                        char_array[x, y] = '\\';
                    }
                    else if (char_array[x, y] == '\\')
                    {
                        char_array[x, y] = '/';
                    }
                    mirror[x, 12 - y] = char_array[x, y];

                }
            }
            return mirror;
        }
        public static char[,] make_forward()
        {
            char[,] pixel = new char[4, 13];
            pixel[0, 0] = ' ';
            pixel[0, 1] = ' ';
            pixel[0, 2] = '_';
            pixel[0, 3] = '_';
            pixel[0, 4] = '_';
            pixel[0, 5] = '_';
            pixel[0, 6] = '_';
            pixel[0, 7] = '_';
            pixel[0, 8] = ' ';
            pixel[0, 9] = ' ';
            pixel[0, 10] = ' ';
            pixel[0, 11] = ' ';
            pixel[0, 12] = ' ';
            pixel[1, 0] = ' ';
            pixel[1, 1] = '/';
            pixel[1, 2] = '|';
            pixel[1, 3] = '_';
            pixel[1, 4] = '|';
            pixel[1, 5] = '|';
            pixel[1, 6] = '_';
            pixel[1, 7] = '\\';
            pixel[1, 8] = '\'';
            pixel[1, 9] = '.';
            pixel[1, 10] = '_';
            pixel[1, 11] = '_';
            pixel[1, 12] = ' ';
            pixel[2, 0] = '(';
            pixel[2, 1] = ' ';
            pixel[2, 2] = ' ';
            pixel[2, 3] = ' ';
            pixel[2, 4] = '_';
            pixel[2, 5] = ' ';
            pixel[2, 6] = ' ';
            pixel[2, 7] = ' ';
            pixel[2, 8] = ' ';
            pixel[2, 9] = '_';
            pixel[2, 10] = ' ';
            pixel[2, 11] = '_';
            pixel[2, 12] = '\\';
            pixel[3, 0] = '=';
            pixel[3, 1] = '\'';
            pixel[3, 2] = '-';
            pixel[3, 3] = '(';
            pixel[3, 4] = '_';
            pixel[3, 5] = ')';
            pixel[3, 6] = '-';
            pixel[3, 7] = '-';
            pixel[3, 8] = '(';
            pixel[3, 9] = '_';
            pixel[3, 10] = ')';
            pixel[3, 11] = '-';
            pixel[3, 12] = '\'';
            return pixel;
        }
    }
}
