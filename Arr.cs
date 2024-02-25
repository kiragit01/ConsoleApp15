using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal static class Arr
    {
        public static int[] Read(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            return nums;
        }

        public static void Write(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {nums[i]}");
            }
        }
    }
}
