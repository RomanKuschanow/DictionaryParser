using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DictionaryParser
{
    public static class Parser
    {
        public static void Parse(string csvPath, string langPath, string lang_langPath)
        {
            var csv = new CSVReader(csvPath);

            var ld = csv.Table.Skip(1).Select(l =>
            {
                List<KeyValuePair<string, string>> newD = new();

                for (int i = 0; i < 4; i++)
                {
                    if (l[i]?.Length == 0)
                    {
                        break;
                    }

                    for (int j = 4; j < 25; j++)
                    {
                        if (l[j]?.Length == 0)
                        {
                            break;
                        }


                        newD.Add(new KeyValuePair<string, string>(l[i], l[j]));
                    }
                }

                return newD;
            }).ToList();

            var d = ld.SelectMany(i => i).Distinct().ToList();

            var lang_str = string.Join(Environment.NewLine, d.Select(i => i.Key));
            var lang_lang_str = string.Join(Environment.NewLine, d.Select(i => i.Value));

            File.WriteAllText(langPath, lang_str);
            File.WriteAllText(lang_langPath, lang_lang_str);
        }
    }
}
