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

// Приклад використання:
// TreeNode root = new TreeNode(1);
// root.left = new TreeNode(2);
// root.right = new TreeNode(2);
// root.left.left = new TreeNode(3);
// root.left.right = new TreeNode(4);
// root.right.left = new TreeNode(4);
// root.right.right = new TreeNode(3);
// Solution sol = new Solution();
// Console.WriteLine(sol.IsSymmetric(root));  // Виведе: True