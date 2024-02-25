using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main()
        {
            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива.
            //Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.

            Task1();

            //Задача 2.Дан одномерный массив. Вывести:
            //а) все неотрицательные элементы;
            //б) все элементы, не превышающие число 100;
            //в) все четные элементы.

            Task2();

            //Задача 3.Заполнить одномерный массив без использования клавиатуры следующими значениями:
            //5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2.Подсчитать количество отрицательных элементов.

            Task3();

            //Задача 4.Составьте программу вычисления среднего арифметического элементов с нечетными номерами.

            Task4();

            //Задача 5.Составьте программу увеличения всех элементов массива в 5 раз.

            Task5();

            Console.ReadKey();
        }

        static void Task1()
        {
            int[] nums = new int[6];
            RandomArray.Small(nums);
            Arr.Write(nums);
            Console.WriteLine(RandomArray.Сheck(nums));
            Console.WriteLine();
        }
        static void Task2()
        {
            int[] nums = new int[50];
            //Arr.Read(nums); //заполнить вручную
            RandomArray.Big(nums); //рандом
            Task2Check.Check(nums);
            Console.WriteLine();
        }
        static void Task3()
        {
            int f = 0;
            int[] nums = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] < 0)
                    f++;
            Console.WriteLine(f);
            Console.WriteLine();
        }
        static void Task4()
        {
            int[] nums = new int[10];
            RandomArray.Small(nums);
            Arr.Write(nums);
            Console.WriteLine(MiddleArr.Arr(nums));
            Console.WriteLine();
        }
        static void Task5()
        {
            int[] nums = new int[10];
            RandomArray.Small(nums);
            Console.WriteLine("Изначальный массив:");
            Arr.Write(nums);
            FiveTimesMore.More(nums);
            Console.WriteLine("Увеличенный в 5 раз:");
            Arr.Write(nums);
        }
    }
}
