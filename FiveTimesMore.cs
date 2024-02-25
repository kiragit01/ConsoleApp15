using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal static class FiveTimesMore
    {
        public static int[] More(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++) 
                nums[i] *= 5;
            return nums;
        }
    }
}
