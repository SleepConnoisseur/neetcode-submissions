public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null) return false; 
        if(subRoot == null) return false; 

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        bool matched = true;

        while(queue.Count > 0){
            var current = queue.Dequeue();
            if(current.left != null) queue.Enqueue(current.left);
            if(current.right != null) queue.Enqueue(current.right);

            if(current.val == subRoot.val){
                match(current,subRoot);
                if(matched) return true;
                matched = true;
            }
        }

        return false;
        
        void match (TreeNode root, TreeNode subRoot){
            if(root.left != null && subRoot.left == null) matched =  false;
            else if(root.left == null && subRoot.left != null) matched =  false;
            else if(root.right != null && subRoot.right == null) matched =  false;
            else if(root.right == null && subRoot.right != null) matched =  false;
            else if(root.val != subRoot.val) matched =  false;
            else{
                if(root.left != null && subRoot.left != null)
                match(root.left , subRoot.left);
                if(root.right != null && subRoot.right != null)
                match(root.right , subRoot.right);
            }
        }
    }

}