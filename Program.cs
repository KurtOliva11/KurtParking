using System;
using Park;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Kurt's Parking");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1.I want to park my vehicle");
        Console.WriteLine("2.I want to go out");
        Console.WriteLine("3.What is your parking rate?");
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();

        if (number == "1")
        {
            Parking.Topark(number);
        }

        if (number == "2")
        {
            Parking.ToOUT(number);
        }

        if (number == "3")
        {
            Parking.Rate(number);
        }

    }





}
