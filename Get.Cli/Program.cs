using Microsoft.Extensions.Configuration;

namespace Get.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                //Console.WriteLine("No args given, program exits.");
                //return;

                args = new string[1] { "test" };
            }


            // Get path from the appsettings.json
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            var path = config.GetRequiredSection("FilePath").Value;


            // Program
            var fileLinesArr = new FileReader(path).GetFileLines();
            var searchText = args[0];
            new TextSearcher().SearchText(fileLinesArr, searchText);
        }
    }
}
