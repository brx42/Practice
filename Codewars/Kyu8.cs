using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Practice.Codewars;

public static class Kyu8
{
    #region Return Negative

    public static int MakeNegative(int number)
    {
        return number <= 0
            ? number
            : -number;
    }

    #endregion

    #region Returning Strings

    public static string Greet(string name)
    {
        string resultString = $"Hello, {name} how are you doing today?";

        return resultString;
    }

    #endregion

    #region Opposite number

    public static int Opposite(int number)
    {
        return number > 0
            ? -Math.Abs(number)
            : Math.Abs(number);
    }

    #endregion

    #region Find Multiples of a Number

    public static List<int> FindMultiples(int integer, int limit)
    {
        List<int> resultValue = new();

        for (int i = integer; i <= limit; i += integer)
        {
            resultValue.Add(i);
        }

        return resultValue;
    }

    #endregion

    #region Twice as old

    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        int ageAtBirth = dadYears - sonYears;

        int twiceAsOld = ageAtBirth * 2;

        return dadYears >= twiceAsOld
            ? dadYears - twiceAsOld
            : twiceAsOld - dadYears;
    }

    #endregion

    #region Sum of positive

    public static int PositiveSum(int[] arr)
    {
        int resultSum = 0;

        foreach (int i in arr)
        {
            if (i >= 0)
            {
                resultSum += i;
            }
        }

        return resultSum;
    }

    #endregion

    #region Convert number to reversed array of digits

    public static long[] Digitize(long n)
    {
        string numbersToStr = n.ToString();

        List<long> result = new();
        for (int i = numbersToStr.Length - 1; i >= 0; i--)
        {
            long convertingNumb = Convert.ToInt64(long.Parse(numbersToStr[i].ToString()));

            result.Add(convertingNumb);
        }

        return result.ToArray();
    }

    #endregion

    #region Opposites Attract

    public static bool LoveFunc(int flower1, int flower2)
    {
        if ((flower1 % 2 == 0 && flower2 % 2 != 0)
            || flower1 % 2 != 0 && flower2 % 2 == 0)
        {
            return true;
        }

        return false;
    }

    #endregion

    #region Abbreviate a Two Word Name

    public static string AbbrevName(string name)
    {
        char firstLetter = name[0];

        int indexSecondLetter = name.IndexOf(' ');
        char secondLetter = name[indexSecondLetter + 1];

        string result = $"{firstLetter}.{secondLetter}";
        return result.ToUpper();
    }

    #endregion

    #region Count Odd Numbers below n

    public static ulong OddCount(ulong n)
    {
        return n / 2;
    }

    #endregion

    #region Get the mean of an array

    public static int GetAverage(int[] marks)
    {
        int sumPoint = marks.Sum();
        int result = sumPoint / marks.Length;
        return result;
    }

    #endregion

    #region Century From Year

    public static int СenturyFromYear(int year)
    {
        int length = year.ToString().Length - 2;

        string firstTwoNumbs = year.ToString().Remove(length);
        string otherNumbs = year.ToString().Remove(0, length);

        int century = Convert.ToInt32(firstTwoNumbs);
        int years = Convert.ToInt32(otherNumbs);

        if (years >= 1)
        {
            century++;
        }

        return century;
    }

    #endregion

    #region Is n divisible by x and y?

    public static bool IsDivisible(int n, int x, int y)
    {
        return n % x == 0 && n % y == 0;
    }

    #endregion

    #region Reversed Strings

    public static string ReversedStrings(string str)
    {
        IEnumerable<char> result = str.Reverse();

        return string.Concat(result);
    }

    #endregion

    #region Reversed Words

    public static string ReverseWords(string str)
    {
        StringBuilder result = new();

        while (true)
        {
            if (!str.Contains(' '))
            {
                result.Append(' ' + str);

                break;
            }

            int lastIndex = str.LastIndexOf(' ');

            result.Append(str[lastIndex..]);

            str = str.Remove(lastIndex);
        }

        return result.Remove(0, 1).ToString();
    }

    #endregion

    #region Did she say hallo? (No solution)

    public static bool ValidateHello(string greetings)
    {
        return Regex.IsMatch(greetings, "hello|ciao|salut|hallo|hola|ahoj|czesc", RegexOptions.IgnoreCase);
    }

    #endregion
}