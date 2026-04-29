public class KthLargest {
    private int K;
    private PriorityQueue<int,int> Nums = new PriorityQueue<int,int>();

    public KthLargest(int k, int[] nums) {
        K = k;
        foreach(var x in nums){
            Nums.Enqueue(x, x);
        }
        while(Nums.Count > K){
            Nums.Dequeue();
        }
    }
    
    public int Add(int val) {
        Nums.Enqueue(val, val);
        while(Nums.Count > K){
            Nums.Dequeue();
        }
        return Nums.Peek();
    }
}
