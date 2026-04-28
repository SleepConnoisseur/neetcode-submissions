public class Solution {
    public int MaxArea(int[] heights) {
        int a = 0;
        int b = heights.Length-1;
        var result = 0;
        while(a<b){
            var x = Math.Min(heights[a],heights[b]) * (b-a);
            result = Math.Max(result,x);
            if(heights[a]<heights[b])a++;
            else b--;
        }
        return result;
    }
}
