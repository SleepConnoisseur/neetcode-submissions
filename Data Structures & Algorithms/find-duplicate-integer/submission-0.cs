public class Solution {
    public int FindDuplicate(int[] nums) {
        var hash = new HashSet<int>();

        foreach(var x in nums){
            if(!hash.Add(x))return x;
        }
        return 0;
    }
}
