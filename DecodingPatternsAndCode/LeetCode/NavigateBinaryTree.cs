using DecodingPatternsAndCode.Tests.LeetCode.BinaryTree;
using System.Collections.Generic;

namespace DecodingPatternsAndCode.Tests.LeetCode
{
    public class NavigateBinaryTree
    {
        public IList<int> PreOrderTraversal(TreeNode root)
        {
            var r = root;
            var list = new List<int> {r.Val};

            if (r.Left != null)
            {
                var l1 = PreOrderTraversal(r.Left);
                if (l1?.Count > 0)
                {
                    list.AddRange(l1);
                }
            }
            if (r.Right != null)
            {
                var r1 = PreOrderTraversal(r.Right);
                if (r1?.Count > 0)
                {
                    list.AddRange(r1);
                }
            }

            return (IList<int>)list;
        }
    }
}
