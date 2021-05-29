using System;

namespace TestDICastleWindsor
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}