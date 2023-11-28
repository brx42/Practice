using System.Text;
using System.Text.RegularExpressions;

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
                    return new[] { i, j };
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

    #region 14

    public static string LongestCommonPrefix(string[] strs)
    {
        int i = 0;
        StringBuilder sb = new();

        string strSort = strs.OrderBy(s => s.Length).First();

        foreach (char c in strSort)
        {
            if (strs.Any(s => s[i] != c))
            {
                break;
            }

            sb.Append(c);
            i++;
        }

        return sb.ToString();
    }

    #endregion

    #region 20

    public static bool IsValid(string s)
    {
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }

        return s.Length == 0;
    }

    #endregion

    #region 136

    public static int SingleNumber(int[] nums)
    {
        return nums
            .GroupBy(x => x)
            .Where(x => x.Count() == 1)
            .Select(x => x.Key)
            .First();
    }

    #endregion

    #region 26

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int i = 0;

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }

        return i + 1;
    }

    #endregion

    #region 28

    public static int StrStr(string haystack, string needle)
    {
        return haystack.Contains(needle)
            ? haystack.IndexOf(needle, StringComparison.Ordinal)
            : -1;
    }

    #endregion

    #region 58

    public static int LengthOfLastWord(string s)
    {
        string[] strArr = s.Split(' ');

        if (strArr.Length == 1)
        {
            return strArr.First().Length;
        }

        return strArr.Last(word => word.Length >= 1).Length;
    }

    #endregion

    #region 67 (No solution)

    public static string AddBinary(string a, string b)
    {
        return Convert.ToString(Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2), 2);
    }

    #endregion

    #region 125

    public static bool IsPalindrome(string s)
    {
        s = Regex.Replace(s, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled).ToLower();

        string ss = string.Concat(s.Reverse());

        return s == ss;
    }

    #endregion

    #region 35

    public static int SearchInsert(int[] nums, int target)
    {
        if (!nums.Contains(target))
        {
            List<int> result = nums.ToList();

            result.Add(target);

            result = result.OrderBy(i => i).ToList();

            return result.IndexOf(target);
        }

        int res = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] == target)
            {
                res = i;
                break;
            }
        }

        return res;
    }

    #endregion

    #region 217

    public static bool ContainsDuplicate(int[] nums)
    {
        return nums.SequenceEqual(nums.Distinct());
    }

    #endregion

    #region 349

    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        int[] result = nums1.Intersect(nums2).ToArray();

        GC.Collect();

        return result;
    }

    #endregion

    #region 175

    public static void CombineTwoTables()
    {
        string sql = """
                     SELECT p.firstName, p.lastName, a.city, a.state
                     FROM Person p
                     LEFT JOIN Address a ON p.personId = a.personId
                     """;
    }

    #endregion

    #region 182

    public static void DuplicateEmails()
    {
        string sql = """
                     select email
                     from Person
                     group by email
                     having count(email) > 1
                     """;
    }

    #endregion

    #region 183

    public static void CustomersWhoNeverOrder()
    {
        string sql = """
                     select c.name as Customers
                     from Customers as c
                     left join Orders as o on c.id = o.customerId
                     where o.customerId is null
                     """;
    }

    #endregion

    #region 181

    public static void EmployeesEarningMoreThanTheirManagers()
    {
        string sql = """
                     select emp1.name as Employee
                     from Employee emp1
                     join Employee emp2 on emp1.managerId = emp2.id
                     where emp1.salary > emp2.salary
                     """;
    }

    #endregion

    #region 196

    public static void DeleteDuplicateEmails()
    {
        string sql = """
                     DELETE FROM Person
                     WHERE Id NOT IN (
                         SELECT Id
                         FROM (
                             SELECT MIN(Id) Id
                             FROM Person
                             GROUP BY Email) p
                         );
                     """;
    }
    
    #endregion
}