using System;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество чисел в массиве"); // ввод чисел в массив
            int k = Int32.Parse(Console.ReadLine());
            int[] nums = new int[k];

            Random rand = new Random();
           
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1,100);
            }

            
            int b1;                                              // сортировка массива
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        b1 = nums[i];
                        nums[i] = nums[j];
                        nums[j] = b1;
                    }
                }
            }
 
            Console.WriteLine("Вывод отсортированного массива"); // вывод массива
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
