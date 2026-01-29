class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        char_map = {}
        max_length = 0
        start = 0
        
        for right in range(len(s)):
            current_char = s[right]
            
            # If the character is already in the map and within the current window
            if current_char in char_map and char_map[current_char] >= start:
                # Jump the start pointer to one position after the last occurrence
                start = char_map[current_char] + 1
            
            # Update the character's last seen index
            char_map[current_char] = right
            
            # Calculate the current window length and update max_length
            current_window_len = right - start + 1
            if current_window_len > max_length:
                max_length = current_window_len
                
        return max_length