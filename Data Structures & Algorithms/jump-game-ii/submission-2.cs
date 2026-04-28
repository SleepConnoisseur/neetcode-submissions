public class Solution {
    public int Jump(int[] nums) {
        int?[] counter = new int?[nums.Length];
        counter[0] = 0;
        for (int i = 0; i < nums.Length; i++) {
            for(int x = i + 1; x <= i + nums[i] && x < nums.Length; x++){
                if(counter[x] == null){
                    counter[x] = counter[i]+1;
                    
                }
                else{
                    counter[x] = Math.Min(counter[x].Value, counter[i].Value+1);
                }
            }
        }
        return counter[counter.Length-1].Value;
    }
}
