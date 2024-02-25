using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal static class RandomArray
    {
        public static Random random = new Random();
        public static int[] Small(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 5);
            }
            return nums;
        }
        public static int[] Big(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(-200, 200);
            }
            return nums;
        }

        public static int Сheck(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++) 
            {
                if (nums[0] == nums[i])
                    return i;
            }
            return 0;
        }

    }
}
