public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        
        var rows = new List<string>();
        for (int i = 0; i < numRows; i++)
            rows.Add("");

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s) {
            rows[currentRow] += c;

           
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;

            currentRow += goingDown ? 1 : -1;
        }

        
        return string.Join("", rows);
    }
}
