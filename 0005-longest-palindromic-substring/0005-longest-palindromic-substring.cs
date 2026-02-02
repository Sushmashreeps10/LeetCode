public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";
        
        int start = 0;
        int end = 0;

        for (int i = 0; i < s.Length; i++) {
            // Case 1: Odd length (center is s[i])
            int len1 = ExpandFromMiddle(s, i, i);
            // Case 2: Even length (center is between s[i] and s[i+1])
            int len2 = ExpandFromMiddle(s, i, i + 1);
            
            int len = Math.Max(len1, len2);
            
            // If we found a longer palindrome, update our pointers
            if (len > end - start) {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }

    private int ExpandFromMiddle(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        // Returns the length of the palindrome found
        return right - left - 1;
    }
}