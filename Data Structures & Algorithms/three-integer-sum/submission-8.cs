public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        nums = nums.OrderBy(x=>x).ToArray();
        var result = new List<List<int>>();
        if(nums.Length < 3) return result;
        var set = new HashSet<string>();
        for(int i = 0; i < nums.Length-2; i++){
            int a = i+1;
            int b = nums.Length -1;
            while(a<b){
                if(nums[i] + nums[a] + nums[b] == 0){
                    var prot = new List<int>(){nums[i], nums[a], nums[b]};
                    var trademark = nums[i].ToString() + nums[a].ToString() + nums[b].ToString();
                    if(set.Add(trademark)) result.Add(prot);
                    a++;
                    continue;
                } 
                else if(nums[i] + nums[a] + nums[b] > 0) b--;
                else a++;
            }
        }
        return result;
    }
}
