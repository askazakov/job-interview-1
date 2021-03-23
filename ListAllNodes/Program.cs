using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAllNodes
{
    public class TreeNode
    {
        public int Value;
        public IEnumerable<TreeNode> Children { get; set; }
    }

    public class Program
    {
        public static IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        {
            var stack = new Stack<TreeNode>();
            foreach (var child in node.Children)
            {
                stack.Push(child);
            }

            return Aux(stack, new List<TreeNode>() {node});
        }

        private static IEnumerable<TreeNode> Aux(Stack<TreeNode> stack, List<TreeNode> result)
        {
            if (!stack.Any())
            {
                return result;
            }

            var last = stack.Pop();
            result.Add(last);

            if (last.Children != null)
            {
                foreach (var child in last.Children)
                {
                    stack.Push(child);
                }
            }

            return Aux(stack, result);
        }

        static void Main(string[] args)
        {
            var root = new TreeNode {Value = 0};
            var child1 = new TreeNode();
            child1.Value = 1;
            var child2 = new TreeNode();
            child2.Value = 2;
            var grandChild1 = new TreeNode {Value = 3};
            var grandChild2 = new TreeNode {Value = 4};
            var grandChild3 = new TreeNode {Value = 23};
            child2.Children = new List<TreeNode>() {grandChild1, grandChild2, grandChild3};

            var grandGrandChild1 = new TreeNode {Value = 5};
            grandChild1.Children = new List<TreeNode>() {grandGrandChild1};

            root.Children = new List<TreeNode>() {child1, child2};
            var result = GetAllNodes(root);
            Console.WriteLine();
        }
    }
}