using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._02
{
    public static class NumberFinder
    {
        /// <summary>
        /// Timer for calculating the execution time of the method "NextBiggerThan"
        /// </summary>
        public static long FindNextBiggerNumberTime(int number)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            FindNextBiggerNumber(number);
            time.Stop();
            return time.ElapsedTicks;
        }
        /// <summary>
        /// Finds the bigger closest number from the input
        /// </summary>
        public static int? FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (number == int.MaxValue)
                {                  
                    return null;
                }
                char[] l = number.ToString().ToCharArray();
                Array.Sort(l);
                char[] lr = new char[l.Length];
                lr = (char[])l.Clone();
                Array.Reverse(lr);
                string g = new string(lr);
                int g1 = Convert.ToInt32(g);
                checked
                {
                    for (int i = number + 1; i <= g1; i++)
                    {
                        char[] ch = i.ToString().ToCharArray();
                        Array.Sort(ch);
                        if (CharArrayCompare(l, ch))
                        {
                            return i;
                        }
                    }
                    return null;
                }
            }
        }
        private static bool CharArrayCompare(char[] charLeft, char[] charRight)
        {
            if (charLeft.Length != charRight.Length)
                return false;
            var length = charLeft.Length;
            for (int i = 0; i < length; i++)
            {
                if (charLeft[i] != charRight[i])
                    return false;
            }
            return true;
        }
    }
}
