using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using ListAllNodes;

namespace ListAllNodesBenchmarks
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private readonly TreeNode root;
        
        private static TreeNode GenerateTree()
        {
            var root = new TreeNode();
            var childA = new TreeNode();
            var childB = new TreeNode();
            root.Children = new[] {childA, childB};
            return root;
        }

        public Benchmarks()
        {
            root = GenerateTree();
        }

        [Benchmark]
        public void StackyRecursiveBenchmark()
        {
            var actual = StackyRecursive.GetAllNodes(root);
        }
        //
        // [Benchmark]
        // public void Scenario2()
        // {
        //     // Implement your benchmark here
        // }
    }
}
