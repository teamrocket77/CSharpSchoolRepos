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

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] ReadingMaterial = new Item[5];
            int i;
            string c, title, author;
            int IBSN, IssueNum;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("What would you like to add to your Reading Material Enter P for Perdidical or B for Book");
                c = Console.ReadLine().ToLower();
                if (c == "p")
                {
                    Console.WriteLine("What's the title?");
                    title = Console.ReadLine();
                    Console.WriteLine("What's the Issue Number?");
                    IssueNum = Int16.Parse(Console.ReadLine());
                    ReadingMaterial[i] = new Periodical(IssueNum, title);
                }
                else if (c == "b")
                {
                    Console.WriteLine("What's the title?");
                    title = Console.ReadLine();
                    Console.WriteLine("Author?");
                    author = Console.ReadLine();
                    Console.WriteLine("What's the Issue Number?");
                    IBSN = Int16.Parse(Console.ReadLine());
                    ReadingMaterial[i] = new Book(author, IBSN, title);
                }
            }

            Console.WriteLine(ReadingMaterial[0].getListing());
            Console.WriteLine(ReadingMaterial[1].getListing());
            Console.WriteLine(ReadingMaterial[2].getListing());
            Console.WriteLine(ReadingMaterial[3].getListing());
            Console.WriteLine(ReadingMaterial[4].getListing());

        }
    }

    abstract class Item
    {
        private string title { get; set; }

        public Item()
        {
            title = "";
        }

        public Item(string title)
        {
            this.title = title;
        }

        public abstract string getListing();
        public override string ToString()
        {
            return (title);
        }
    }

    class Book : Item
    {
        private int ibsn_number;
        private string author { get; set; }

        public Book()
        {

        }
        public Book(string author, int ibsn_number, string title) : base(title)
        {
            this.author = author;
            this.ibsn_number = ibsn_number;
        }

        public override string getListing()
        {
            return (
@"Book Name - " + base.ToString() + "\n" +
"Author - " + author + "\n" +
"IBSN# - " + ibsn_number.ToString());
        }
    }

    class Periodical : Item
    {
        private int issueNum { get; set; }

        public Periodical()
        {

        }

        public Periodical(int issueNum, string title) : base(title)
        {
            this.issueNum = issueNum;

        }

        public override string getListing()
        {
            return (
@"
Periodical Title - " + base.ToString() + "\n" +
"Issue # - " + issueNum.ToString());
        }
    }

}
