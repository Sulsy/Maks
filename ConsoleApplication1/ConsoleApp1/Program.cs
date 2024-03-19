using System;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: dotnet run -p YourProjectName.csproj <path_to_cshtml>");
            return;
        }

        string cshtmlFilePath = args[0];
        string htmlFilePath = args[1];
        ConvertCshtmlToHtml(cshtmlFilePath,htmlFilePath);
    }

    public static void ConvertCshtmlToHtml(string cshtmlFilePath,string htmlFilePath)
    {
        if (File.Exists(cshtmlFilePath))
        {
            string cshtmlContent = File.ReadAllText(cshtmlFilePath);
            File.WriteAllText(htmlFilePath, cshtmlContent);

            Console.WriteLine("Conversion successful! :"+htmlFilePath+"sc:"+cshtmlContent);
        }
        else
        {
            Console.WriteLine($"File {cshtmlFilePath} not found.");
        }
    }
}