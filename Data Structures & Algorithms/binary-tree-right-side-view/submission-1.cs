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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        
        var queue = new Queue<TreeNode>();
        if(root != null) queue.Enqueue(root);

        while(queue.Count > 0){
            int qCount = queue.Count;
            for(int i = 1; i <= qCount; i++){
                var x = queue.Dequeue();
                if(x.left != null)queue.Enqueue(x.left);
                if(x.right != null)queue.Enqueue(x.right);

                if(i == qCount){
                    result.Add(x.val);
                }
            }
        }

        return result;
    }
}
