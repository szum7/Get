using System;

namespace Get.Cli
{
    class FileReader
    {
        private string filePath;

        public FileReader(string path)
        {
            this.filePath = path;
        }

        public string[] GetFileLines()
        {
            try
            {
                return System.IO.File.ReadAllLines(this.filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Reading failed.");
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
