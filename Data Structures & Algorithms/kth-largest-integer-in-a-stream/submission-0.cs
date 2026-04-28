public class KthLargest {
    private PriorityQueue<int, int> minHeap;
    private int K;

    public KthLargest(int k, int[] nums) {  
        minHeap = new PriorityQueue<int,int>();
        foreach(var x in nums){
            minHeap.Enqueue(x, x);
        }
        K = k;
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        while(minHeap.Count > K){
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}
