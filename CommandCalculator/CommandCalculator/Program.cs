using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            CheckInput();

        }

        static void CheckInput()
        {
            string rawData = Console.ReadLine();
            string[] commands = rawData.Split(' ');
            if (commands[0] == "add")
            {
                int results = Convert.ToInt32(commands[1]) + Convert.ToInt32(commands[2]);
                Console.WriteLine(commands[1] + " + " + commands[2] + " = " + results);
            }

            Console.ReadLine();
        }
    }
}
