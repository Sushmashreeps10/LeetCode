public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        Dictionary<char, string> phoneMap = new Dictionary<char, string>() {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        Backtrack(0, digits, phoneMap, "", result);
        return result;
    }

    private void Backtrack(
        int index,
        string digits,
        Dictionary<char, string> phoneMap,
        string current,
        List<string> result) {

        if (index == digits.Length) {
            result.Add(current);
            return;
        }

        string letters = phoneMap[digits[index]];

        foreach (char c in letters) {
            Backtrack(index + 1, digits, phoneMap, current + c, result);
        }
    }
}
