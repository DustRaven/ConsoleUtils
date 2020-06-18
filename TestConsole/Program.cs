using System;
using System.Text;
using ConsoleUtils;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen(80, 40, true);
            screen.Create();
            Console.ReadLine();
        }
    }
}
