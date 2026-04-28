public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> sett = new HashSet<int>();
        foreach(var x in nums){
            if(!sett.Add(x))return true;
        }
        return false;
    }
}
