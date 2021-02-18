using System;

using System.IO;

namespace GalPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Booting System");

            //Details has been moved to a different class called FalProcessor
            GalProcessor galProcessor = new GalProcessor();
            galProcessor.Initiate();

            //When End Not Reached, repeat forever
            while (!galProcessor.ReachedEnd()) {
                Console.Write(galProcessor.CurrentLine());
                Console.ReadLine();
                galProcessor.Next();
            }
            Console.WriteLine("Press Enter once more to exit the system");
            Console.ReadLine();
        }
    }
}
