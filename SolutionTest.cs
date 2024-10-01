using System;
using NUnit.Framework;

[TestFixture]
public class SolutionTest {
    [Test]
    public void TestSymmetricTree() {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);
        
        Solution sol = new Solution();
        Assert.IsTrue(sol.IsSymmetric(root));
    }

    [Test]
    public void TestAsymmetricTree() {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.right = new TreeNode(3);
        root.right.right = new TreeNode(3);
        
        Solution sol = new Solution();
        Assert.IsFalse(sol.IsSymmetric(root));
    }

    [Test]
    public void TestEmptyTree() {
        Solution sol = new Solution();
        Assert.IsTrue(sol.IsSymmetric(null));
    }

    [Test]
    public void TestSingleElementTree() {
        TreeNode root = new TreeNode(1);
        
        Solution sol = new Solution();
        Assert.IsTrue(sol.IsSymmetric(root));
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right) {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        return (left.val == right.val) && IsMirror(left.right, right.left) && IsMirror(left.left, right.right);
    }
}