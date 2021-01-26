using System;

namespace _1_kulkulator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите 1 число:");
            string operand1 = Console.ReadLine();
            int a = Convert.ToInt32(operand1);
            Console.Write("Введите 2 число:");
            string operand2 = Console.ReadLine();
            int b = Convert.ToInt32(operand2);
            Console.Write("Введите знак арифметической операции(*, /, -, +):");
            string sign = Console.ReadLine();
            double cost = 0;
            switch (sign)
            {
                case "-":
                    cost = a - b;
                    Console.Write("Разность данных чисел:");
                    Console.Write(cost);
                    Console.ReadLine();
                    break;
                case "+":
                    cost = a + b;
                    Console.Write("Сумма данных чисел:");
                    Console.Write(cost);
                    Console.ReadLine();
                    break;
                case "*":
                    cost = a * b;
                    Console.Write("Произведение данных чисел:");
                    Console.Write(cost);
                    Console.ReadLine();
                    break;
                case "/":
                    if (a != 0)
                    {
                        if (b != 0)
                        {
                            cost = (float)a / b;
                            Console.Write("Деление данных чисел:");
                            Console.Write(cost);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Деление на 0!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Делить на 0 нельзя!");
                    }
                    break;

                default:
                    Console.Write("Неверный выбор. Пожалуста выберите (*, /, -, +):");
                    break;
            }
            Console.ReadKey();
        }
    }
}
