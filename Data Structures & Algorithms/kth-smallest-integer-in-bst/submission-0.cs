

public class Solution {
    List<int> reee = new List<int>();
    public int KthSmallest(TreeNode root, int k) {

        DFS(root); 
        return reee[k-1];

        void DFS(TreeNode root){
            if(root == null)return;
            if(reee.Count >= k)return; 

            DFS(root.left);
            reee.Add(root.val);
            DFS(root.right);
        }
    }
}
