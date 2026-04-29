public class Solution {
    public int Search(int[] nums, int target, int min = 0, int max = -1) {
        if (max == -1){
            if(nums.Length == 0) return -1;
            if(target < nums[0]) return -1;
            if(target > nums[nums.Length-1]) return -1;
            
            max = nums.Length - 1;
        }
            

        if (min > max)
            return -1;

        int mid = min + (max - min) / 2;

        if (nums[mid] == target)
            return mid;
        if (nums[mid] > target)
            return Search(nums, target, min, mid - 1);

        return Search(nums, target, mid + 1, max);
    }
}
