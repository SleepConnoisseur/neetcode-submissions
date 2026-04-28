/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> Postorder(Node root) {
        List<int> result = new List<int>();
        if(root == null) return result;
        InTrav(result, root);
        return result;
    }

    private void InTrav(List<int> result, Node root){
        foreach(var x in root.children){
            InTrav(result, x);
        }
        result.Add(root.val);
    }
}