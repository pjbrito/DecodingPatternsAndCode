using DecodingPatternsAndCode.Tests.LeetCode;
using DecodingPatternsAndCode.Tests.LeetCode.BinaryTree;
using System.Collections.Generic;
using Xunit;

namespace DecodingPatternsAndCode.Tests.LeetCodeTests
{
    public class LeetCodeNavigateBinaryTreeTests
    {
        [Fact]
        public void ReturnPreOrderNavigationNodeRLSorting()
        {
            var u = InitBinaryTreeRootRL(out var n);

            var res = u.PreOrderTraversal(n);

            Assert.NotNull(res);
            var expectedList = new List<int> { 1, 2, 3 };
            Assert.Equal(expectedList, res);
        }

        [Fact]
        public void ReturnPreOrderNavigationNodeRLRSorting()
        {
            var u = InitBinaryTreeRootRLR(out var n);

            var res = u.PreOrderTraversal(n);

            Assert.NotNull(res);
            var expectedList = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(expectedList, res);
        }

        private static NavigateBinaryTree InitBinaryTreeRootRL(out TreeNode n)
        {
            var u = new NavigateBinaryTree();

            n = new TreeNode(1);
            n.Right = new TreeNode(2);
            n.Right.Left = new TreeNode(3);
            return u;
        }

        private static NavigateBinaryTree InitBinaryTreeRootRLR(out TreeNode n)
        {
            var u = new NavigateBinaryTree();

            n = new TreeNode(1);
            n.Right = new TreeNode(2);
            n.Right.Left = new TreeNode(3);
            n.Right.Right = new TreeNode(4);
            return u;
        }

    }
}
