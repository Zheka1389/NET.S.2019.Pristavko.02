using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Pristavko._02
{
    public static class FindNthRoots
    {
        /// <summary>
        /// Finds root of n-th power of the number with the accuracy
        /// </summary>
        public static double FindNthRoot(double number, int n, double accuracy)
        {
            if (n == 1)
            {
                return number;
            }
            if (n % 2 == 0 && number < 0 || n < 2 || accuracy > 1 || accuracy < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double current = 0.1;
            double next = (1.0 / n) * ((n - 1) * current + number / Math.Pow(current, n - 1));
            while (Math.Abs(next - current) > accuracy)
            {
                current = next;
                next = 1.0 / n * ((n - 1) * current + number / Math.Pow(current, n - 1));
            }

            return next;
        }
    }
}
