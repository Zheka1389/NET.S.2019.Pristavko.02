using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._02
{
    public static class FilterDigits
    {
        /// <summary>
        /// Filtering the array on the content of the digit in the number
        /// </summary>
        public static int[] FilterDigit(int digit, params int[] a)
        {
            if (a.Length == 0)
            {
                throw new ArgumentNullException();
            }
            List<int> result = new List<int>();
            
            foreach (int i in a)
            {
                if (i.ToString().Contains(digit.ToString()))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
