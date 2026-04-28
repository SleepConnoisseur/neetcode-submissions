public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        if(nums.Length == 0) return new int[0];
        if(k > nums.Length) return new int[0];

        int[] result = new int[(nums.Length - k )+ 1];
        for(int i = 0 ; i <= nums.Length - k ; i++){
            for(int j = i ; j < i+k ; j++){
                if(j == i){
                    result[i] = nums[j];
                }
                else{
                    result[i] = Math.Max(result[i], nums[j]);
                }
            }
        }
        return result;
    }
}
