public class Solution {
    public int SingleNumber(int[] nums) {
        int x = nums[0];

        for(int i = 1; i < nums.Length ; i++){
            x ^= nums[i];
        }

        return x;
    }
}
