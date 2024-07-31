using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanced02
{
    internal class Class1
    {
        #region Q1
        public static void reverse(ref ArrayList arr)
        {
            int count = 0;
            if (arr != null)
            {
                for (int i = arr.Count - 1; i > arr.Count / 2; i--)
                {
                    var temp = arr[i];
                    arr[i] = arr[count];
                    arr[count] = temp;
                    count++;
                }
            }

        }
        #endregion
        #region Q2
        public static List<int> EvenNum(List<int> ints) 
        {
            List<int> result = new List<int>();
            if(ints != null)
            {
                for(int i =0;  i < ints.Count; i++)
                {
                    if (ints[i]%2 == 0)
                    {
                        result.Add(ints[i]);
                    }
                }
            }
            return result; 
        }
        #endregion
        #region Q4
        public static int nonReapeted(string str)
        {
            if (str is not null)
            {
                Dictionary<char, int> pairs = new Dictionary<char, int>();
                for (int i = 0; i < str.Length; i++)
                {
                    if (pairs.ContainsKey(str[i]))
                    {
                        pairs[str[i]]++;
                    }
                    else
                    {
                        pairs.Add(str[i], 1);
                    }
                }
                for (int i = 0; i < str.Length; i++)
                {
                    if (pairs[str[i]] == 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion
    }
}
