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

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking();
            Savings savings = new Savings();
            decimal decimalamt;
            float floatamt;
            int input = 0;
            string prompt =
@"1.  Withdraw from Checking 
2.  Withdraw from Savings 
3.  Deposit to Checking 
4.  Deposit to Savings 
5.  Balance of Checking 
6.  Balance of Savings 
7.  Award Interest to Savings now 
8.  Quit";


            //while loop to control input
            while (input != 8)
            {
                Console.WriteLine("");
                Console.WriteLine(prompt);
                input = Int16.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("How much would you like to withdraw from Checking?");
                        floatamt = float.Parse(Console.ReadLine());
                        decimalamt = (decimal)Math.Round(floatamt, 2);
                        checking.Withdrawl(decimalamt);
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to withdraw from Savings?");
                        floatamt = float.Parse(Console.ReadLine());
                        decimalamt = (decimal)Math.Round(floatamt, 2);
                        savings.Withdrawl(decimalamt);
                        break;
                    case 3:
                        Console.WriteLine("How much would you like to deposit into checking?");
                        floatamt = float.Parse(Console.ReadLine());
                        decimalamt = (decimal)Math.Round(floatamt, 2);
                        checking.Deposit(decimalamt);
                        break;
                    case 4:
                        Console.WriteLine("How much would you like to deposit into savings?");
                        floatamt = float.Parse(Console.ReadLine());
                        decimalamt = (decimal)Math.Round(floatamt, 2);
                        savings.Deposit(decimalamt);
                        break;
                    case 5:
                        //Your for the both of these
                        Console.WriteLine("Your {0}", checking.ToString());
                        break;
                    case 6:
                        Console.WriteLine("Your {0}", savings.ToString());
                        break;
                    case 7:
                        savings.AccrueIntrest();
                        break;
                }
            }
        }
    }

    class Account
    {
        protected static int _accountCounter = 1001;
        public decimal Balance { get; private protected set; }
        //protected int _accountNum;
        public int AccountNum { get; private protected set; }
        public Account()
        {
            Balance = 0;
            AccountNum = _accountCounter++;
        }
        public Account(decimal Balance)
        {
            this.Balance = Balance;
            AccountNum = _accountCounter++;
        }
        public void Withdrawl(decimal cashout)
        {
            if (cashout < 0)
            {
                Console.WriteLine("Sorry you cannot Withdraw Negative amounts");
                return;
            }
            Balance -= cashout;
            return;
        }
        public void Deposit(decimal cashin)
        {
            if(cashin < 0)
            {
                Console.WriteLine("Sorry you cannot deposit Negative amounts");
                return;
            }
            Balance += cashin;
            return;
        }
    }
    class Checking : Account
    {
        public Checking() : base()
        {

        }
        public Checking(decimal Balance) : base(Balance)
        {
        }

        public new void Withdrawl(decimal cashout)
        {
            if (cashout < 0)
            {
                Console.WriteLine("Sorry you cannot Withdraw Negative amounts");
                return;
            }
            if (Balance - cashout < 0)
            {
                Console.WriteLine("Charging an overdraft fee " +
                    "of $20 because account is below $0");
                Balance -= (cashout + 20);
            }
            else Balance -= cashout;
            return;
        }
        public override string ToString()
        {
            return ("Available Checking " + AccountNum.ToString() + " Balance: " + Balance.ToString("F2"));
        }
    }
    class Savings : Account
    {
        private int _depositinstances = 0;
        public Savings() : base()
        {

        }
        public Savings(decimal Balance): base(Balance)
        {

        } 

        public new void Withdrawl(decimal cashout)
        {
            if (cashout < 0)
            {
                Console.Write("Sorry you cannot withdraw negative amounts");
                return;
            }
            if (Balance - cashout < 500)
            {
                Console.WriteLine("Charging a fee of $10 because " +
                    "you are below $500");
                Balance -= (10 + cashout);
            }
            else Balance -= cashout;
        }
        public new void Deposit(decimal cashin)
        {
            _depositinstances++;
            if (cashin < 0)
            {
                Console.Write("Sorry you cannot deposit negative amounts");
                return;
            }

            if (_depositinstances > 5)
            {
                Console.WriteLine("Charging a fee of $10.");
                Balance -= 10;
            }
            Console.WriteLine("This is deposit #{0} for this account", _depositinstances);
            Balance += cashin;
        }
        public void AccrueIntrest()
        {
            decimal interest;
            interest = (decimal)Math.Round((1.015 * (Double)Balance), 2)-Balance;
            Console.WriteLine("Customer earned {0} in interest", interest);
            Balance += interest;
        }
        public override string ToString()
        {
            return ("Available Savings "+ AccountNum.ToString() +" Balance: " + Balance.ToString("F2"));
        }
    }
}