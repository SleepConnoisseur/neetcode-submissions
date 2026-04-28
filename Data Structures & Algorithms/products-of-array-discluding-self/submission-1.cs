public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var non0Product = 1;
        var Ocount = 0;
        foreach(var x in nums){
            if(x != 0) non0Product *= x;
            else Ocount +=1;
        } 
        var result = new int[nums.Length];
        if(Ocount > 1) return result;
        if(Ocount == 1){
            for(int i = 0; i< nums.Length; i++){
                if(nums[i] == 0){
                    result[i] = non0Product;
                }
            }
            return result;
        }
        for(int i = 0; i< nums.Length; i++){
            if(nums[i] != 0){
                result[i] = non0Product/nums[i];
            }
        }
        return result;
    }
}
