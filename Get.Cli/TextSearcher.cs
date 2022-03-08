using System;

namespace Get.Cli
{
    class TextSearcher
    {
        public void SearchText(string[] lines, string text)
        {
            if (lines == null || lines.Length == 0)
            {
                Console.WriteLine("No results due to empty text.");
                return;
            }

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
