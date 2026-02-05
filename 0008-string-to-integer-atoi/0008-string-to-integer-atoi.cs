public class Solution
{
    public int MyAtoi(string s)
    {
        int i = 0;
        int n = s.Length;
        long result = 0;
        int sign = 1;

        // 1. Skip leading whitespaces
        while (i < n && s[i] == ' ')
        {
            i++;
        }

        // 2. Check sign
        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        // 3. Convert digits
        while (i < n && char.IsDigit(s[i]))
        {
            result = result * 10 + (s[i] - '0');

            // 4. Handle overflow
            if (sign == 1 && result > int.MaxValue)
                return int.MaxValue;

            if (sign == -1 && -result < int.MinValue)
                return int.MinValue;

            i++;
        }

        return (int)(sign * result);
    }
}
