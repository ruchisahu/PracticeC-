using System;

namespace dependencyInjection1
{
    internal class Logger
    {
        internal void Log(string v)
        {
            Console.WriteLine( $"Logging {v}");
        }
    }
}