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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null) return result;
        InTrav(result, root);
        return result;
    }

    private void InTrav(List<int> result, TreeNode root){
        result.Add(root.val);
        if(root.left != null){
            InTrav(result, root.left);
        }
        if(root.right != null){
            InTrav(result, root.right);
        }
    }
}