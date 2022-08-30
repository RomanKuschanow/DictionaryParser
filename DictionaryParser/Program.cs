using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DictionaryParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type csv File path");
            string csvPath = Console.ReadLine();

            Console.WriteLine("Type lang File path");
            string langPath = Console.ReadLine();

            Console.WriteLine("Type lang_lang File path");
            string lang_langPath = Console.ReadLine();

            Parser.Parse(csvPath, langPath, lang_langPath);
        }
    }
}
