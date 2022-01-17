using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleCode
{
    public class LeetCode_13_RomanToInteger
    {
        // using tradition way
        public static int RomanToInt(string s) {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                    result += 1;
                else if (s[i] == 'V')
                    result += 5;
                else if (s[i] == 'X')
                    result += 10;
                else if (s[i] == 'L')
                    result += 50;
                else if (s[i] == 'C')
                    result += 100;
                else if (s[i] == 'D')
                    result += 500;
                else if (s[i] == 'M')
                    result += 1000;
            }

            if (s.IndexOf("IV") != -1 || s.IndexOf("IX") != -1)
                result -= 2;
            if (s.IndexOf("XL") != -1 || s.IndexOf("XC") != -1)
                result -= 20;
            if (s.IndexOf("CD") != -1 || s.IndexOf("CM") != -1)
                result -= 200;

            return result;
        }

        // using Dictionary
        //public static int RomanToInt(string s)
        //{

        //    if (s == null || s.Length == 0)
        //        return 0;

        //    Dictionary<char, int> dic = new Dictionary<char, int>()
        //{
        //    {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        //};

        //    int res = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i + 1 < s.Length)
        //        {
        //            char currChar = s[i];
        //            char nextChar = s[i + 1];
        //            if (dic[currChar] >= dic[nextChar])
        //                res += dic[currChar];
        //            else
        //            {
        //                res += (dic[nextChar] - dic[currChar]);
        //                i++;
        //            }
        //        }
        //        else
        //            res += dic[s[i]];
        //    }

        //    return res;
        //}
        public static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IIV")); ;
        }
    }
}
