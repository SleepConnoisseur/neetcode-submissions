public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for(int i = 0, j = 1; i<j && j < prices.Length; ){
            maxProfit = Math.Max(maxProfit, Math.Max(0, prices[j] - prices[i]));
            if(prices[i] > prices[j]){
                i = j;
                j++;
            }
            else{
                j++;
            }
        }
        return maxProfit;
    }
}
