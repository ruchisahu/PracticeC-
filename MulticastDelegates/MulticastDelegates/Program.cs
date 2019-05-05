using System;

namespace MulticastDelegates
{
    class Program
    {
        static void WriteProgreeToConsole(int percentComplete) => Console.WriteLine(percentComplete);

        static void WriteProgreeToFile(int percentComplete) => System.IO.File.WriteAllText("progree.txt",percentComplete.ToString());
        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgreeToConsole;
            p += WriteProgreeToFile;
            ProgressReport.Hardwork(p);
            Console.WriteLine("Hello World!");
        }
    }
}
