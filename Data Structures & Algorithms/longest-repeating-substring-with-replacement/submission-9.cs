// public class Solution {
//     public int CharacterReplacement(string s, int k) {
//         if(s.Length == 0)return 0;
//         if(k == 0) return longestSubstring(s);//longest substring method;
//         Dictionary<char, int> set = new Dictionary<char, int>();

//         int max = 0;

//         char currentChar = s[0];
//         int currentCharCount = 0;

//         for(int i = 0 ; i < s.Length; i++){
//             if(currentChar == s[i]){currentCharCount++;} 
//             else{currentChar = s[i]; currentCharCount = 1;}

//             if(set.Count < 2){
//                 if(set.ContainsKey(s[i])){
//                     set[s[i]] += 1;
//                 }
//                 else{
//                     set.Add(s[i], 1);
//                 }
//                 max = Math.Max(max, set.Values.Sum());
//             }
//             else{
//                 if(set.ContainsKey(s[i])){
//                     //add to this characters counter
//                     set[s[i]] += 1;

//                     // check if counter surpassed K
//                     if(set[s[i]] > k){
//                         // if counter surpassed K, check if the other is still under K, if both surpassed K => reset
//                         if((set.Values.Sum() - set[s[i]]) > k){
//                             // if we need to close this loop but it's already the last character, just end looping
//                             if(i == s.Length-1) break;

//                             //reset set and restart counters
//                             set.Clear();
//                             i -= currentCharCount;
//                             currentCharCount = 0;
//                             continue;
//                         }
//                     }
//                     max = Math.Max(max, set.Values.Sum());
//                 }
//                 else{
//                     //reset set and restart counters
//                     set.Clear();
//                     i -= currentCharCount;
//                     currentCharCount = 0;
//                 }
//             }
//         }

//         return max;
//     }

//     public int longestSubstring(string s){
//         int max = 0;
//         int count = 0;
//         char currentChar = s[0];
//         foreach(char x in s){
//             if(currentChar == x) {
//                 count++;
//             }
//             else{
//                 max = Math.Max(max, count);
//                 currentChar = x;
//                 count = 1;
//             }
//         }
//         max = Math.Max(max, count);
//         return max;
//     }
// }

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] frequency = new int[26];
        int Count =0;
        int left = 0;
        int MaxLen = 0;

        for(int i =0; i< s.Length; i++){
            Count = Math.Max(++frequency[s[i]- 'A'], Count);

            if(i - left+1 > Count +k){
                frequency[s[left] - 'A']--;
                left++;
            }
            MaxLen = Math.Max(MaxLen, i-left+1);
        }

        return MaxLen;
    }
}
