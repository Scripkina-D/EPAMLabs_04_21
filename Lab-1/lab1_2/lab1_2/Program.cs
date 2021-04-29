using System;

namespace lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Выберите действие : + ,  - ,  * , /  \n");
            string b1 = Console.ReadLine();
            switch (b1)

            {
                case "+":
                    Console.WriteLine($"Ответ: {a1 + a2} ");
                    break;
                case "-":
                    Console.WriteLine($"Ответ: {a1 - a2} ");
                    break;
                case "*":
                    Console.WriteLine($"Ответ: {a1 * a2} ");
                    break;
                case "/":
                    Console.WriteLine($"Ответ: {a1 / a2} ");
                    break;
                default:
                    Console.WriteLine("Вы выбрали неизвестное действие");
                    break;
            }
         }
    }
}
