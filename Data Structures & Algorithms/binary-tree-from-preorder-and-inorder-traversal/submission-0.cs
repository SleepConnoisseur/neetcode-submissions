/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0 || inorder.Length == 0) return null;

        var root = new TreeNode(preorder[0]);
        var mid = Array.IndexOf(inorder, preorder[0]);

        var leftPreorder = new int[mid];
        Array.Copy(preorder,1,leftPreorder,0,mid);

        var rightPreorder = new int[preorder.Length - (mid+1)];
        Array.Copy(preorder,mid+1,rightPreorder,0,preorder.Length - (mid+1));

        var leftInorder = new int[mid];
        Array.Copy(inorder,0, leftInorder,0,mid);

        var rightInorder = new int[inorder.Length - (mid+1)];
        Array.Copy(inorder,mid+1, rightInorder,0,inorder.Length - (mid+1));

        root.left = BuildTree(leftPreorder, leftInorder);
        root.right = BuildTree(rightPreorder, rightInorder);

        return root;
    }
}
