public class Solution {
   public int LongestConsecutive(int[] nums) {
    var set = new HashSet<int>(nums);
    var largest = 0;

    foreach (int num in set) {
        if (set.Contains(num - 1)) continue; // not a sequence start, skip

        var currentNum = num;
        var currentCount = 1;

        while (set.Contains(currentNum + 1)) {
            currentNum++;
            currentCount++;
        }

        if (currentCount > largest) largest = currentCount;
    }
    return largest;
}
}
