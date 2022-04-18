using System;
using System.Collections.Generic;

namespace Kth_Smallest_Element_in_a_BST
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class TreeNode
  {
    public TreeNode left { get; set; }
    public TreeNode right { get; set; }
    public int val { get; set; }

    public TreeNode(int val = 0)
    {
      left = right = null;
      this.val = val;
    }
  }

  public class Solution
  {
    List<int> inorder = new List<int>();
    public int KthSmallest(TreeNode root, int k)
    {
      KthSmallest_Helper(root);
      return inorder[k - 1];
    }

    private void KthSmallest_Helper(TreeNode root)
    {
      if (root == null) return;
      KthSmallest_Helper(root.left);
      inorder.Add(root.val);
      KthSmallest_Helper(root.right);
    }
  }
}
