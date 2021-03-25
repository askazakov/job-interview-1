using BenchmarkDotNet.Running;

namespace ListAllNodesBenchmarks
{
    public static class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}