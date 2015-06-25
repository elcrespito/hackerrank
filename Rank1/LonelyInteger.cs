using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Rank1
{
    public class LonelyInteger
    {
        public static int Solution(int[] a)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (dict.ContainsKey(a[i]))
                {
                    dict[a[i]]++;
                }
                else
                {
                    dict[a[i]] = 1;
                }
            }

            return dict.Single(p => p.Value == 1).Key;
        }
    }
}
