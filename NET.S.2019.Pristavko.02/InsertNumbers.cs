using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._02
{
    public static class InsertNumbers
    {
        /// <summary>
        /// bits of the second number took positions from bit start
        /// by bits end (bits are numbered from right to left).
        /// </summary>
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            if (i <= j && i >= 0 && j >= 0 && i <= 31 && j <= 31)
            {
                int temp = ~(-1 << (j - i + 1));
                return ((numberIn & temp) << i) | numberSource;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
