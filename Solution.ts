/**
 * Represents a node in a binary tree.
 */
class BinaryTreeNode {
    /**
     * The value stored in the node.
     */
    val: number;

    /**
     * The left child of the node.
     * It is either another BinaryTreeNode or null if there is no left child.
     */
    left: BinaryTreeNode | null;

    /**
     * The right child of the node.
     * It is either another BinaryTreeNode or null if there is no right child.
     */
    right: BinaryTreeNode | null;

    /**
     * Creates an instance of BinaryTreeNode.
     * @param val - The value to store in the node. Defaults to 0 if not provided.
     * @param left - The left child of the node. Defaults to null if not provided.
     * @param right - The right child of the node. Defaults to null if not provided.
     */
    constructor(val?: number, left?: BinaryTreeNode | null, right?: BinaryTreeNode | null) {
        this.val = (val === undefined ? 0 : val);
        this.left = (left === undefined ? null : left);
        this.right = (right === undefined ? null : right);
    }
}

function isSymmetric(root: BinaryTreeNode | null): boolean {
    if (!root) return true;
    return isMirror(root.left, root.right);
}

function isMirror(left: BinaryTreeNode | null, right: BinaryTreeNode | null): boolean {
    if (!left && !right) return true;
    if (!left || !right) return false;
    return (left.val === right.val) && isMirror(left.right, right.left) && isMirror(left.left, right.right);
}

// Example usage:
const root = new BinaryTreeNode(1);
root.left = new BinaryTreeNode(2);
root.right = new BinaryTreeNode(2);
root.left.left = new BinaryTreeNode(3);
root.left.right = new BinaryTreeNode(4);
root.right.left = new BinaryTreeNode(4);
root.right.right = new BinaryTreeNode(3);
console.log(isSymmetric(root));  // Outputs: true
