using DecodingPatternsAndCode.Tests.LeetCode.BinaryTree;
using System.Collections.Generic;

namespace DecodingPatternsAndCode.Tests.LeetCode
{
    public class NavigateBinaryTree
    {
        public IList<int> PreOrderTraversal(TreeNode root)
        {
            var l = root.Left;
            var r = root.Right;

            var lst = new List<int> {root.Val};

            if (l != null)
            {
                var lr = PreOrderTraversal(l);
                if (lr?.Count > 0)
                {
                    lst.AddRange(lr);
                }
            }
            if (r != null)
            {
                var rr = PreOrderTraversal(r);
                if (rr?.Count > 0)
                {
                    lst.AddRange(rr);
                }
            }

            return (IList<int>)lst;
        }
    }
}
