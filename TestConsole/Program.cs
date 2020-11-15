using System;

namespace GeneratedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the various scenarios
            Console.WriteLine("Running HelloWorld:\n");

            // The static call below is generated at build time, and will list the syntax trees used in the compilation
            HelloWorldGenerated.HelloWorld.SayHello();

            Console.ReadLine();
        }
    }
}
