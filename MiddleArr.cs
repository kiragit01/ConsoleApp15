using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal static class MiddleArr
    {
        public static double Arr(int[] nums)
        {
            double m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    m += nums[i];
                }
            }
            return m / (nums.Length / 2);
        }
    }
}
