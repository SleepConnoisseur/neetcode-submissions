public class Solution {
    public bool CanJump(int[] nums, int startPos = 0) {
      var maxReach = 0;
      for(int i = 0; i < nums.Length ; i++){
        if (i > maxReach) return false; 
        maxReach = Math.Max(maxReach, i+nums[i]);
      }
      return true;
    }
}
