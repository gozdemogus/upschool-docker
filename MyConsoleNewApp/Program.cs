using System;

namespace MyConsoleNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 1000)
            {
                Console.WriteLine(i + "Merhaba ankara");
                i++;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

