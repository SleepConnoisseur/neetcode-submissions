/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Dictionary<int, List<Node>> result = new Dictionary<int, List<Node>>();
        if(root == null) return null;
        BFS(result, root, 1);

        foreach (var x in result) {
            var list = x.Value;
            for (int i = 0; i < list.Count() - 1; i++) {
                list[i].next = list[i + 1];
            }
        }
        return root;
    }

    private void BFS(Dictionary<int, List<Node>> result, Node root, int level) {
        if (!result.ContainsKey(level)) {
            result.Add(level, new List<Node>());
        }
        result[level].Add(root);
        if (root.left != null)
            BFS(result, root.left, level+1);
        if (root.right != null)
            BFS(result, root.right, level+1);
    }
}