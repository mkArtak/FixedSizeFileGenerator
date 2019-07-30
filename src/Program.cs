using System;
using System.IO;
using System.Threading.Tasks;

namespace FixedSizeFileGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long length = long.Parse(args[0]);
            Console.WriteLine($"Generating file with size {length} bytes");
            string path = Path.GetTempFileName();
            using StreamWriter writer = File.CreateText(path);
            for (long l = 0; l < length; l++)
            {
                writer.Write('0');
            }

            await writer.FlushAsync();

            Console.WriteLine($"Finished writing data to {path}.");
        }
    }
}
