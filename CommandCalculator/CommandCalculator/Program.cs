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
            if(args.Length != 0)
            {
                double results = add(args) + multiply(args) + divide(args);
                Console.WriteLine(results);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What would you like to do?");
            string rawData = "";
            while (rawData != "quit")
            {
                rawData = Console.ReadLine();
                string[] commands = rawData.Split(' ');

                double results = add(commands) + multiply(commands) + divide(commands);

                Console.WriteLine(results);
                Console.WriteLine("enter 'quit' to quit or else to continue");
            }
        }
        static double add(string[] inputs)
        {
            double results = 0;
            if (inputs[0] == "add")
            {
                for (int i = 1; i < inputs.Length; i++)
                {
                    results += Convert.ToDouble(inputs[i]);
                }
            }
            return results;
        }
        static double multiply(string[] inputs)
        {
            double results = 0;
            if (inputs[0] == "multiply")
            {
                results = 1;
                for (int i = 1; i < inputs.Length; i++)
                {
                    results *= Convert.ToDouble(inputs[i]);
                }
            }
            return results;
        }
        static double divide(string[] inputs)
        {
            double results = 0;
            if (inputs[0] == "divide")
            {
                results = Convert.ToDouble(inputs[1]);
                results *= results;
                for (int i = 1; i < inputs.Length; i++)
                {
                    results /= Convert.ToDouble(inputs[i]);
                }
            }
            return results;
        }
    }
}
