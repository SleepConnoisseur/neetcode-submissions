public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        for(int L = 0, R = 1; R < prices.Length;){
            if(prices[L] > prices[R]) L += 1;
            else{
                max = Math.Max(max , (prices[R] - prices[L]) );
                R += 1;
            } 
        }
        return max;
    }
}
