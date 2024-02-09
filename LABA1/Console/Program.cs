using System;
using System.Text;

namespace LABA
{
    public class toTest
    {
         public int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public bool Palindrom(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
            return true;

        }

        public int Factorial(int x)
        {
            int a = 1;
            for (int i = x; i > 0; i--)
            {
                a *= i;
            }
            return a;
        }

        public int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        public bool Includes(string s, string sub)
        {
            return s.Contains(sub);
        }

        public bool simpleNumber(int n)
        {
            for (int i = 2; i < n - 1; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public int Reverse(int number)
        {
            string number2 = number.ToString();
            string reverse = new string(number2.Reverse().ToArray());
            char minus = reverse[reverse.Length - 1];
            if (minus == '-')
            {
                string res = minus + reverse.Substring(0, reverse.Length - 1);
                if (long.Parse(res) <= 2147483647 && long.Parse(res) >= -2147483647)
                {
                    return int.Parse(res);
                }
            }
            if (long.Parse(reverse) <= 2147483647 && long.Parse(reverse) >= -2147483647)
            {
                return int.Parse(reverse);
            }

            return 0;
        }

        public string toRoman(int number)
        {
            if (number < 0 || number > 3999)
                return "error";

            if (number == 0) return "N";

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] dict = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(dict[i]);
                }
            }

            return result.ToString();
        }
    }

    public class program
    {
        public static void Main()
        {

        }
    }
}