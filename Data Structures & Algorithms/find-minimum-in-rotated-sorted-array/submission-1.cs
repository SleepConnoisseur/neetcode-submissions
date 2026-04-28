public class Solution {
    public int FindMin(int[] nums) {
        if(nums.Length == 1) return nums[0];
        if(nums[nums.Length-1] > nums[0])return nums[0];
        for(int i = 1 ; i < nums.Length ; i++){
            if(nums[i-1]>nums[i])return nums[i];
        }
        return 0;
    }
}
