public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        if(root == null) return null;
        TreeNode lowest = null;

        if( p.val > q.val){
            TreeNode temp = q;
            q = p;
            p = temp;
        }

        DFS(root);

        return lowest;
        
        void DFS(TreeNode root){
            if(p.val <= root.val && root.val <= q.val && lowest == null) lowest = root;
            if(p.val < root.val && q.val < root.val && root.left != null) DFS(root.left);
            if(p.val > root.val && q.val > root.val && root.right != null) DFS(root.right);
        }
    }
}