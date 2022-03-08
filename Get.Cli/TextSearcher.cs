using System;
using System.Collections.Generic;
using System.Linq;

namespace Get.Cli
{
    class Result
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }

    class TextSearcher
    {
        public void SearchText(string[] lines, string searchTxt)
        {
            if (lines == null || lines.Length == 0)
            {
                Console.WriteLine("No results due to empty text.");
                return;
            }

            var results = new List<Result>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (line.ToLower().Contains(searchTxt.ToLower()) && IsTitleLine(lines, i))
                {
                    var result = new Result();
                    result.Title = line;

                    var j = i;
                    while (line.Trim() != "")
                    {
                        line = lines[++j];

                        result.Body += line + "\n";

                        if (j == lines.Length - 1)
                            break;
                    }
                    i = j;
                    results.Add(result);
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("[No results found.]");
                return;
            }

            results = results.OrderBy(x => x.Title.Length - searchTxt.Length).ToList();
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Title}");
                Console.WriteLine("-----");
                Console.Write(result.Body);
            }
        }

        private bool IsTitleLine(string[] lines, int i)
        {
            return (i == 0 || lines[i - 1].Trim() == "");
        }
    }
}
