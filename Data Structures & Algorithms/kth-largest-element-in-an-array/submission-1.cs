public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if(nums.Length == 0) return 0;

        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(var x in nums){
            queue.Enqueue(x , x * -1);
        }

        for(int i = 1; i <= k; i++){
            if(i == k){
                return queue.Dequeue();
            }
            queue.Dequeue();
        }
        return 0;
    }
}
