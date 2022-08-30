using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DictionaryParser
{
    public class CSVReader
    {
        public List<string[]> Table { get; }

        public CSVReader(string fileName)
        {
            Table = ReadLines(fileName);
        }

        private List<string[]> ReadLines(string fileName)
        {
            var list = new List<string[]>();
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var cells = line.Split(',');
                list.Add(cells);
            }
            return list;
        }
    }
}
