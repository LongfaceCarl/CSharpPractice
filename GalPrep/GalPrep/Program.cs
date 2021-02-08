using System;

using System.IO;

namespace GalPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String copy = File.ReadAllText("text.txt");
            string[] arrayText = copy.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int i = 0;
            String name = "Leo";
            String sig = "*";
            while (i < arrayText.Length) {
                while (arrayText[i] == "")
                {
                    i++;
                }
                if (arrayText[i].StartsWith(sig + "name"))
                {
                    name = arrayText[i].Substring(6);
                    i++;
                }
                Console.Write(name + ": " + arrayText[i]);
                Console.ReadLine();
                i++;
            }
            Console.ReadLine();
            
        }
    }
}
