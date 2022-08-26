using System;
using System.Diagnostics;

namespace script1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Web Browser: ");
            string browser = Console.ReadLine();
            Console.WriteLine("\r\nDirect URL [1]");
            Console.WriteLine("Internet Search [2]");
            Console.Write("> ");
            string option = Console.ReadLine();
            Console.Write("input> ");
            string input = Console.ReadLine();

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = browser + ".exe";
            processStartInfo.UseShellExecute=true;

            if (option.Equals("1"))
            {
                processStartInfo.Arguments = input;
                Process.Start(processStartInfo);
            }
            else if(option.Equals("2"))
            {
                processStartInfo.Arguments = "https://search.brave.com/search?q=" + input + "&source=desktop";
                Process.Start(processStartInfo);
            }
            else
            {
                Console.WriteLine("invalid option!");
            }
        }
    }
}