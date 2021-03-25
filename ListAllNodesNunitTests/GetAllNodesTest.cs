using ListAllNodes;
using NUnit.Framework;

namespace ListAllNodesNunitTests
{
    public class GetAllNodesTest
    {
        [Test]
        public void TestTwoChildren()
        {
            var root = new TreeNode();
            var childA = new TreeNode();
            var childB = new TreeNode();
            root.Children = new[] {childA, childB};
            Assert.AreEqual(new[] {root, childB, childA}, StackyRecursive.GetAllNodes(root));
        }
    }
}