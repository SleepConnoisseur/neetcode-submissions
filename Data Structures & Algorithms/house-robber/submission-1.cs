public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0)return 0;
        if(nums.Length == 1)return nums[0];
        
        int[] totals = new int[nums.Length];
        totals[0] = nums[0];
        totals[1] = nums[1];

        for(int i = 0; i < nums.Length -2 ; i++){
            totals[i+2] = Math.Max(totals[i+2], (nums[i+2] + totals[i]));
            if(i < nums.Length -3){
            totals[i+3] = Math.Max(totals[i+3], (nums[i+3] + totals[i]));
            }
        }
        return Math.Max(totals[nums.Length-1], totals[nums.Length-2]);
    }
}
