public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        nums = nums.OrderBy(x=>x).Distinct().ToArray();
        var currentCount = 1;
        var largest = 1;

        for(int i = 1; i< nums.Length; i++){
            if(nums[i-1]+1 == nums[i]){
                currentCount +=1;
                if(currentCount > largest) largest = currentCount;
            }
            else currentCount = 1;
        }
        return largest;
    }
}
