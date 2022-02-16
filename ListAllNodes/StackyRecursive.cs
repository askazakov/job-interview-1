using System.Collections.Generic;
using System.Linq;

namespace ListAllNodes
{
    public class TreeNode
    {
        public IEnumerable<TreeNode> Children { get; set; }
    }

    public static class StackyRecursive
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
            if (stack.Count == 0)
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
    }
}