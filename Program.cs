using System;

namespace Currency_and_Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome! enter 'c' to use currency converter or 't' to use temperature converter");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.WriteLine("You have selected the currency converter");
                Console.WriteLine("Enter 'p' to convert from pounds or 'e' to convert from euro");
                string choice = Console.ReadLine();

                if (choice == "p")
                {
                    Console.WriteLine($"Enter your amount in british pounds");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine($"The amount in euros is {euros.ToString("0.00")}");
                }
                else if (choice == "e")
                {
                    Console.WriteLine($"Enter your amount in euros");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    Console.WriteLine($"The amount in British pounds is {pounds.ToString("0.00")}");
                }
                else
                {
                    Console.WriteLine($"Did not select valid option");
                }
            }
            else
            {
                Console.WriteLine("Welcome to the temperature converter");
                Console.WriteLine($"Please enter 'c' to convert from celsius or 'f' to convert from fahrenheit");
                string choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.WriteLine("Enter a temperature in celsius");
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = celsius * 1.18f + 32f;
                    Console.WriteLine($"The temperature in fahrenheit is {fahrenheit}");
                }
                else if (choice == "f")
                {
                    Console.WriteLine("Enter a temperature in fahrenheit");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (fahrenheit - 32f) / 1.8f;
                    Console.WriteLine($"The temperature in celsius is {celsius}");
                }
                else
                {
                    Console.WriteLine($"Did not enter valid option");
                }
            }
        }
    }
}
