/*
 * Student: Vincent Cradler
 * Date: 08292021
 * Class: CSE 1322L 
 * section: #02
 * 
 * Assignment: {Lab 2}
 * Instructor: Kavitha
 */
using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt, ChosenOption, NewPrice;
            int ConvertOption;
            double ConvertedPrice;
            Boolean BreakFlag = false;
            StockItem Milk = new StockItem("1 Gallon of Milk", 3.6, 15);
            StockItem Bread = new StockItem("1 Loaf of Bread", 1.98, 30);
            prompt = @"1.Sold One Milk
2.Sold One Bread
3.Change price of Milk
4.Change price of Bread
5.Add Milk to Inventory
6.Add Bread to Inventory
7.See Inventory
8.Quit";
            while (true)
            {
                Console.WriteLine(prompt);
                ChosenOption = Console.ReadLine();
                ConvertOption = Int32.Parse(ChosenOption);
                switch (ConvertOption)
                {
                    case 1:
                        Milk.LowerQuantity(1);
                        break;
                    case 2:
                        Bread.LowerQuantity(1);
                        break;
                    case 3:
                        Console.WriteLine("What's is the new price of Milk?");
                        NewPrice = Console.ReadLine();
                        ConvertedPrice = Double.Parse(NewPrice);
                        Milk.Price = ConvertedPrice ;
                        break;
                    case 4:
                        Console.WriteLine("What's is the new price of Bread?");
                        NewPrice = Console.ReadLine();
                        ConvertedPrice = Double.Parse(NewPrice);
                        Bread.Price = ConvertedPrice;
                        break;
                    case 5:
                        Console.WriteLine("How many Loaves of Bread do you want to add?");
                        NewPrice = Console.ReadLine();
                        ConvertedPrice = Double.Parse(NewPrice);
                        Milk.RaiseQuantity((int)ConvertedPrice);
                        break;
                    case 6:
                        Console.WriteLine("How many cartons of Milk do you want to add?");
                        NewPrice = Console.ReadLine();
                        ConvertedPrice = Double.Parse(NewPrice);
                        Bread.RaiseQuantity((int)ConvertedPrice);
                        break;
                    case 7:
                        Console.WriteLine(Milk.ToString());
                        Console.WriteLine(Bread.ToString());
                        break;

                    case 8:
                        BreakFlag = true;
                        break;
                }
                if (BreakFlag) break;
            }
            Console.WriteLine("Have a great day");
        }
        class StockItem
        {
            public string description { get; protected private set; }
            private protected static int id = 0;
            private int _id;
            public int Id { get; set; }
            public int quantity;
            private double _price;
            public double Price
            {
                get
                {
                    return _price;
                }
                set
                {
                    if (value > 0 && value - Math.Round(value, 2) > .01)
                    {
                        _price = Math.Round(value, 2);
                    }
                    else if (value < 0) {
                        _price = 0;
                        Console.WriteLine("Error Error you cannot set a price to be below 0");
                    }
                    else _price = value;
                }
            }

            public StockItem()
            {
                this.description = null;
                Id = id++;
            }
            public StockItem(string description, double price, int quantity)
            {
                this.description = description;
                this.Price = price;
                this.quantity = quantity;
                Id = id++;
            }

            public void RaiseQuantity(int quantity)
            {
                if (this.quantity + quantity < 0)
                {
                    Console.WriteLine("Sorry we you cannot add negative loaves");
                    this.quantity = 0;
                    return;
                }
                this.quantity += quantity;
            }
            public void LowerQuantity(int quantity)
            {
                if (this.quantity + quantity < 0)
                {
                    Console.WriteLine("Sorry we don't have anymore of that item");
                    this.quantity = 0;
                    return;
                }
                this.quantity -= quantity;
            }
            public String prettyPrint(float item)
            {
                return (item.ToString("F2"));
            }
            public override string ToString()
            {
                return (" Item Number: " + Id.ToString("G") + " is " + description + " has price $" + prettyPrint((float)Price) + " we currenly have " + quantity.ToString("G") + " in stock");
                
            }
        }
    }
}
