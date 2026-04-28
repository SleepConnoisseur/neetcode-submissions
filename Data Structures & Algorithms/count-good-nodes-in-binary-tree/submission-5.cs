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
    int result = 0;

    public int GoodNodes(TreeNode root) {
    DFSGoodNodes(root, new List<int>());
    return result;
    }

    public void DFSGoodNodes(TreeNode root, List<int> PreviousValues){
        if(root !=  null){
            if(!PreviousValues.Any(x=> x > root.val))result++;

            List<int> copy = new List<int>(PreviousValues);
            copy.Add(root.val);

            DFSGoodNodes(root.left, copy);
            DFSGoodNodes(root.right, copy);
        }
    }
}
