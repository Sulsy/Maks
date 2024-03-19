using System;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: dotnet run -p YourProjectName.csproj <path_to_cshtml> <output_directory>");
            return;
        }

        string cshtmlFilePath = args[0];
        string outputDirectory = args[1];
        ConvertCshtmlToHtml(cshtmlFilePath, outputDirectory);
    }

    public static void ConvertCshtmlToHtml(string cshtmlFilePath, string outputDirectory)
    {
        if (File.Exists(cshtmlFilePath))
        {
            string cshtmlContent = File.ReadAllText(cshtmlFilePath);
            string htmlFilePath = Path.Combine(outputDirectory, "index.html");
            File.WriteAllText(htmlFilePath, cshtmlContent);

            Console.WriteLine("Conversion successful! HTML file created at: " + htmlFilePath);
        }
        else
        {
            Console.WriteLine($"File {cshtmlFilePath} not found.");
        }
    }
}