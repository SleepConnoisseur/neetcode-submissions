public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = Enumerable.Repeat(1, nums.Length).ToArray();
        for(int i = 0; i< nums.Length; i++){
            for(int j = 0; j< nums.Length; j++){
                if(i != j) result[i] *= nums[j];
            }
        }
        return result;
    }
}
