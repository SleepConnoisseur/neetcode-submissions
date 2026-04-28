public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> heap = new PriorityQueue<int,int>();
        foreach(var x in stones) heap.Enqueue(x, x* -1);
        while(heap.Count > 1){
            int x = heap.Dequeue();
            int y = heap.Dequeue();
            if(x == y){
                //both deleted
            }
            else if(x < y){
                y = y-x;
                heap.Enqueue(y, y* -1);
            }
            else if(y < x){
                x = x-y;
                heap.Enqueue(x, x* -1);
            }
        }
        if(heap.Count == 0) return 0;
        else return heap.Dequeue();
    }
}
