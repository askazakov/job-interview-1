using System.Linq;
using ListAllNodes;
using Xunit;

namespace ListAllNodesTests
{
    public class GetAllNodesTest
    {
        [Fact]
        public void TestTwoChildren()
        {
            var root = new TreeNode();
            var childA = new TreeNode();
            var childB = new TreeNode();
            root.Children = new[] {childA, childB};
            var actual = Program.GetAllNodes(root);
            Assert.Equal(actual.ToArray(), new[] {root, childB, childA});
        }
    }
}
