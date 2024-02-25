using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal static class Task2Check
    {
        public static void Check(int[] nums)
        {
            Console.WriteLine("Все неотрицательные элементы:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            Console.WriteLine("Все элементы, не превышающие число 100:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 100)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            Console.WriteLine("Все четные элементы:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }

        }
    }
}
