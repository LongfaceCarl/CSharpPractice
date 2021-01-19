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
            Console.WriteLine("Hello, how many people do you have?");
            string responseOne = Console.ReadLine();
            Console.WriteLine("Okay, here's our menu:");
            Console.WriteLine("jingDian: 30 yuan");
            Console.WriteLine("teDian: 20 yuan");
            Console.WriteLine("xiaoDian: 10 yuan");
            Console.WriteLine("siuDian: 5 yuan");
            Console.WriteLine("Dish: 50 yuan");
            Console.WriteLine("Rice: 2 yuan");
            Console.WriteLine();
            Console.WriteLine("How many jingDian do you want?");
            string responseTwo = Console.ReadLine();
            Console.WriteLine("How many teDian do you want?");
            string responseThree = Console.ReadLine();
            Console.WriteLine("How many xiaoDian do you want?");
            string responseFour = Console.ReadLine();
            Console.WriteLine("How many siuDian do you want?");
            string responseFive = Console.ReadLine();
            Console.WriteLine("How many Dish do you want?");
            string responseSix = Console.ReadLine();
            Console.WriteLine("How many Rice do you want?");
            string responseSeven = Console.ReadLine();

            int twoConvert = Convert.ToInt16(responseTwo);
            int threeConvert = Convert.ToInt16(responseThree);
            int fourConvert = Convert.ToInt16(responseFour);
            int fiveConvert = Convert.ToInt16(responseFive);
            int sixConvert = Convert.ToInt16(responseSix);
            int sevenConvert = Convert.ToInt16(responseSeven);
            int oneConvert = Convert.ToInt16(responseOne);

            int jingDianTotal = twoConvert * 30;
            int teDianTotal = threeConvert * 20;
            int xiaoDianTotal = fourConvert * 10;
            int siuDianTotal = fiveConvert * 5;
            int dishTotal = sixConvert * 50;
            int riceTotal = sevenConvert * 2;

            float total = jingDianTotal + teDianTotal + xiaoDianTotal + siuDianTotal + dishTotal + riceTotal;
            float average = total / oneConvert;

            Console.WriteLine("Your total is " + total);
            Console.ReadLine();
            Console.WriteLine("Every customer should pay " + average);
            Console.ReadLine();


        }
    }
}
