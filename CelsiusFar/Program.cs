using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusFar
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            
            
          
            Console.WriteLine("Hello, Welcome to CelsiusFar!");
            Console.WriteLine("Do you want to convert into Celsius or Fahrenheit?");

            
            Start:
            Console.Write("If you want to convert into Celsius, press 1.");
            Console.WriteLine(" If you want to convert into Fahrenheit, press 2.");
            userChoice = int.Parse(Console.ReadLine());

            double answer;
            double input;


            if(userChoice == 1)
            {
                Console.WriteLine("You chose to convert Fahrenheit into Celsius.");
                Console.WriteLine("Please insert your temperature in Fahrenheit.");
                input = double.Parse(Console.ReadLine());
                answer = (input - 32) * 5 / 9;
                Console.WriteLine($"{input} Fahrenheit is equal to {answer} Celsius.");
                Console.ReadLine();
                goto Start;
            }

            if(userChoice == 2)
            {
                Console.WriteLine("You chose to convert Celsius into Fahrenheit.");
                Console.WriteLine("Please insert your temperature in Celsius.");
                input = double.Parse(Console.ReadLine());
                answer = (input * 9) / 5 + 32;
                Console.WriteLine($"{input} Celsius is equal to {answer} Fahrenheit.");
                Console.ReadLine();
                goto Start;
            }

            else
            {
                Console.WriteLine("Please insert number 1 or number 2. Read instructions carefully!");
                goto Start;
            }

            Console.ReadLine();
        }
    }
}
