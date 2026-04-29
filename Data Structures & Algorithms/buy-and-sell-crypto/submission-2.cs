public class Solution {
    public int MaxProfit(int[] prices) {
        var max = 0;
        for(int i = 0; i < prices.Length-1; i++){
            if(prices[i] >= prices[i+1]) continue;
            else{
                for(int x = i+1; x < prices.Length; x++){
                    max = Math.Max(max, prices[x] - prices[i]);
                }
            }
        }
        return max;
    }
}
