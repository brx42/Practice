namespace Practice.LeetCode;

public static class Easy
{
    #region #1

    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (target == nums[j] + nums[i])
                {
                    return new[] {i, j};
                }
            }
        }

        return null;
    }

    #endregion

    #region #9

    public static bool IsPalindrome(int x)
    {
        string value = x.ToString();

        string result = string.Empty;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            result += value[i].ToString();
        }

        return result == value;
    }

    #endregion

    #region 13

    public static int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (i == 0)
            {
                result = s[i] switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => throw new ArgumentOutOfRangeException()
                };
                continue;
            }

            result = s[i] switch
            {
                'I' => result + 1,
                'V' => s[i - 1] == 'I' ? result + 3 : result + 5,
                'X' => s[i - 1] == 'I' ? result + 8 : result + 10,
                'L' => s[i - 1] == 'X' ? result + 30 : result + 50,
                'C' => s[i - 1] == 'X' ? result + 80 : result + 100,
                'D' => s[i - 1] == 'C' ? result + 300 : result + 500,
                'M' => s[i - 1] == 'C' ? result + 800 : result + 1000,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return result;
    }

    #endregion
}