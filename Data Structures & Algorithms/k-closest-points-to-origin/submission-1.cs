public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],double> queue = new PriorityQueue<int[],double>();

        foreach(int[] xy in points){
            double distance = Math.Sqrt(xy[0] * xy[0] + xy[1] * xy[1]);
            queue.Enqueue(xy, distance);
        }

        List<int[]> result = new List<int[]>();
        for(int i = 0; i < k ; i++){
            result.Add(queue.Dequeue());
        }
        return result.ToArray();
    }
}
