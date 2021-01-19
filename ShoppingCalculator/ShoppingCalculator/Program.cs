using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            int peopleCount = askFor("Hello, how many people do you have?");
            string receipt = "";

            Console.WriteLine("Okay, here's our menu:");
            Console.WriteLine("jingDian:        30 yuan");
            Console.WriteLine("teDian:          20 yuan");
            Console.WriteLine("xiaoDian:        10 yuan");
            Console.WriteLine("siuDian:         05 yuan");
            Console.WriteLine("Dish:            50 yuan");
            Console.WriteLine("Rice:            02 yuan");
            Console.WriteLine();

            for (int i = 0; i < peopleCount; i++)
            {
                Console.WriteLine("\nWhat would you like to order?");
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();

                int jingDianTotal = askFor("How many jingDian do you want?") * 30;
                int teDianTotal = askFor("How many teDian do you want?") * 20;
                int xiaoDianTotal = askFor("How many xiaoDian do you want?") * 10;
                int siuDianTotal = askFor("How many siuDian do you want?") * 5;
                int dishTotal = askFor("How many Dish do you want?") * 50;
                int riceTotal = askFor("How many Rice do you want?") * 2;
                float totalPerPerson = jingDianTotal + teDianTotal + xiaoDianTotal + siuDianTotal + dishTotal + riceTotal;

                receipt += name + ", your total is: " + totalPerPerson + "\n";

                total += totalPerPerson;
            }

            Console.Write(receipt);
            Console.WriteLine("The total is " + total);
            Console.WriteLine("Every customer should pay if AA:" + total / peopleCount);
            Console.ReadLine();
        }

        static int askFor(string prompt)
        {
            Console.Write(prompt + "> ");
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
