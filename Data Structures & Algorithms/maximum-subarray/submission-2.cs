public class Solution {
    public int MaxSubArray(int[] nums) {
        
        if(nums.Length == 0) return 0;

        int max = nums[0];
        for(int i = 0; i < nums.Length ; i++){
            int current = nums[i];
            max = Math.Max(max,current);
            for(int j = i+1; j < nums.Length ; j++){
                if(nums[j] > (current + nums[j])) break;
                current = current + nums[j];
                max = Math.Max(max,current);
            }
        }
        return max;
    }
}
