using BenchmarkDotNet.Running;

namespace ContainsDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Benchmark benchmark = new();
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}