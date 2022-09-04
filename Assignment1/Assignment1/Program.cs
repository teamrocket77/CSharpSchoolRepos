/*
 * Student: Vincent Cradler
 * Date 08262021
 * Class: CSE 1322L 
 * section:#02
 * 
 *  Assignment: Assignment 1
 *  Instructor: Kavitha
 *  Summary: 
 *    Program attempts to find the amount of coins needed for some amount of change
 */

using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            float total_amt, total_weight;
            int quant;
            double roundedDivisor;




            Notes twenties = new Notes(20);
            Notes tens = new Notes(10);
            Notes fives = new Notes(5);
            Notes ones = new Notes(1);

            Coins quarters = new Coins(.25f, .2f);
            Coins dimes = new Coins(.10f, .08f);
            Coins nickels = new Coins(.05f, .176f);
            Coins pennies = new Coins(.01f, .088f);

            dimes.increaseQuantity(41);
            nickels.increaseQuantity(17);
            pennies.increaseQuantity(132);
            ones.increaseQuantity(33);
            fives.increaseQuantity(12);
            tens.increaseQuantity(2);
            twenties.increaseQuantity(5);

            Console.WriteLine(twenties.ToString());
            Console.WriteLine(tens.ToString());
            Console.WriteLine(fives.ToString());
            Console.WriteLine(ones.ToString());
            Console.WriteLine(quarters.ToString());
            Console.WriteLine(dimes.ToString());
            Console.WriteLine(nickels.ToString());
            Console.WriteLine(ones.ToString());


            total_amt = GetTotalAmount();
            total_weight = GetTotalWeight();
            Console.WriteLine("Total Money is $" + total_amt.ToString("F2") + " Total Weight is " + total_weight.ToString() + "oz");

            Console.WriteLine("How much money do you need? ");


            String amtNeededStr = Console.ReadLine();
            double amtNeeded = float.Parse(amtNeededStr);
            if (amtNeeded / 20 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded/20);
                quant = twenties.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                twenties.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "$20 Note");
                amtNeeded -= roundedDivisor * 20;
            }
            if (amtNeeded / 10 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / 10);
                quant = tens.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                tens.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "$10 Note");
                amtNeeded -= roundedDivisor * 10;
            }
            if (amtNeeded / 5 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / 5);
                quant = fives.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                fives.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "$5 Note");
                amtNeeded -= roundedDivisor * 5;
            }
            if (amtNeeded / 1 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / 1);
                quant = ones.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                ones.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "$1 Note");
                amtNeeded -= roundedDivisor;
            }
            if (amtNeeded / .25 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / .25);
                quant = quarters.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                quarters.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "Quarter");
                amtNeeded -= roundedDivisor * .25;
            }
            if (amtNeeded / .1 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / .1);
                quant = dimes.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                dimes.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "dime");
                amtNeeded -= roundedDivisor * .1;
            }
            if (amtNeeded / .05 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / .05);
                quant = nickels.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                nickels.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "nickle");
                amtNeeded -= roundedDivisor * .05;
            }
            if (amtNeeded / .01 >= 1)
            {
                roundedDivisor = Math.Floor(amtNeeded / .01);
                quant = pennies.getQuantityOnHand();
                if (roundedDivisor > quant) roundedDivisor = quant;
                pennies.descreaseQuantity((int)roundedDivisor);
                PrintItems((int)roundedDivisor, "penny");
                amtNeeded -= roundedDivisor * .01;
            }

            total_amt = GetTotalAmount();
            if (amtNeeded > GetTotalAmount())
            {
                Console.Write("I don't have enough money. ");
            }
            if (amtNeeded >= .001)
            {
                Console.WriteLine("I still owe you ${0}", amtNeeded.ToString("F2"));
            }

            total_weight = GetTotalWeight();
            Console.WriteLine("Total Remaining money is $" + total_amt.ToString("F2") + " Total Weight is " + total_weight.ToString() + "oz");


            //Methods to just return values
            float GetTotalAmount()
            {
                return twenties.getTotalValue() + tens.getTotalValue() +
    ones.getTotalValue() + fives.getTotalValue() +
    quarters.getTotalValue() + dimes.getTotalValue()
    + nickels.getTotalValue() + pennies.getTotalValue();

            }
            float GetTotalWeight()
            {
                return quarters.getTotalWeight() + dimes.getTotalWeight()
                + nickels.getTotalWeight() + pennies.getTotalWeight();
            }
            void PrintItems(int i, string denom)
            {
                for(int j = 0; j< i; j++)
                {
                    Console.WriteLine("Give them a {0}", denom);
                }
            }
            
        }

    }
    class Coins
    {
        private int quanityOnHand;
        private float denomination;
        private readonly float weight;

        public Coins(float denomination, float weight)
        {
            this.denomination = denomination;
            this.weight = weight;
            this.quanityOnHand = 0;
        }
        public float getTotalWeight()
        { 
            return this.weight * this.quanityOnHand;
        }
        public float getTotalValue()
        {
            return this.denomination * this.quanityOnHand;
        }

        public void increaseQuantity(int num)
        {
            this.quanityOnHand += num;
        }
        public void descreaseQuantity(int num)
        {
            
            this.quanityOnHand -= num;
            if (this.quanityOnHand < 0) this.quanityOnHand = 0;
        }
        public int getQuantityOnHand()
        {
            return this.quanityOnHand;
        }
        public string printPretty(float amount)
        {
            return ("$" + amount.ToString("F2"));
        }
        public override string ToString()
        {
            return (printPretty(getQuantityOnHand()*denomination) + " in " + printPretty(denomination) + " coins.");    
        }
    }
    class Notes
    {
        private int quanityOnHand;
        private float denomination;

        public Notes(int denomination)
        {
            this.denomination = denomination;
            quanityOnHand = 0;
        }
        public int getTotalValue()
        {
            float a = this.denomination * this.quanityOnHand;
            return (int)Math.Round(a, 0);
        }

        public void increaseQuantity(int num)
        {
            this.quanityOnHand += num;
        }
        public void descreaseQuantity(int num)
        {

            this.quanityOnHand -= num;
            if (this.quanityOnHand < 0) this.quanityOnHand = 0;
        }
        public int getQuantityOnHand()
        {
            return this.quanityOnHand;
        }
        public String printPretty(float amount)
        {
            return ("$" + amount.ToString("F2"));
        }
        public override string ToString()
        {
            return (printPretty(getQuantityOnHand()*denomination) + " in " + printPretty(this.denomination) + " notes");
        }
    }
}
