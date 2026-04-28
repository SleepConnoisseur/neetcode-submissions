public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length < 2) return new int[2];
        int i = 0;
        int j = numbers.Length-1;
        while(i < numbers.Length && j >= 0){
            if(numbers[i] + numbers[j] == target) return new int[2]{i+1,j+1};
            else if(numbers[i] + numbers[j] > target) j--;
            else i++;
        }
        return new int[2];
    }
}
