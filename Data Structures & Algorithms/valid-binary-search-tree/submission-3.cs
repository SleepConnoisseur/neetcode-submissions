public class Solution {
    public bool IsValidBST(TreeNode root) {
        return BST(root, int.MinValue, int.MaxValue);

        bool BST(TreeNode root, int left, int right){
            
            if(root == null) return true;

            if(!(left < root.val && root.val < right)) return false;

            return ( BST(root.left , left , root.val ) &&
            BST(root.right , root.val , right) );

        }
    }
}
