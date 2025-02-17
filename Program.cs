using System;
public class SeriesSum
{
    public static void Main(string[] args)
    {
        int number;
        // Цикл для работы с пользователем.
        while (true)
        {
            Console.Write("\nВведите номер задачи или 0 для выхода: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода. Введите число.");
                continue;
            }
            switch (number)
            {
                case 0:
                    Console.WriteLine("Пока");
                    return;
                case 3:
                    task_3();
                    break;
                case 2:
                    task_2();
                    break;
                case 1:
                    task_1();
                    break;
                default:
                    Console.WriteLine("Неверный формат введите ещё раз");
                    break;
            }
        }
    }
    static void task_1()
    {
        float start, end, step;
        while (true)
        {
            try
            {
                Console.Write("Введите начало: ");
                start = float.Parse(Console.ReadLine());
                Console.Write("Введите конец: ");
                end = float.Parse(Console.ReadLine());
                Console.Write("Введите шаг: ");
                step = float.Parse(Console.ReadLine());
                if (step == 0)
                {
                    Console.WriteLine("Шаг не может быть 0");
                    continue;
                }
                if (start > end && step > 0)
                {
                    Console.WriteLine("Начало должно быть меньше конца, если шаг положителен.");
                    continue;
                }
                if (start < end && step < 0)
                {
                    Console.WriteLine("Начало должно быть больше конца, если шаг отрицателен.");
                    continue;
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод.  Введите целые числа.");
            }
        }
        Console.WriteLine("\nФормула (2 + x * x)/Sin(x)");
        Console.WriteLine("  X   |   Итог");
        for (double x = start; (step > 0 && x < end) || (step < 0 && x > end); x += step)
        {
            try
            {
                double result = (2 + Math.Pow(x, x)) / Math.Sin(x);
                Console.WriteLine($"{x}   |   {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"{x}   |   Деление на ноль!");
            }
        }
    }
    static void task_2()
    {
        double cumulativeProduct = 1;

        // Цикл с шагом 0.1 от 0.1 до 10 (включая 10)
        for (double i = 0.1; i <= 10; i += 0.1)
        {
            // На каждом шаге умножаем текущее значение на (1 + sin(i))
            cumulativeProduct *= (1 + Math.Sin(i));
        }
        Console.WriteLine("Задание (1+sin 0.1 )*(1+sin 0.2 )… (1+sin 10 )");
        // Выводим результат
        Console.WriteLine($"Итог: {cumulativeProduct}");
    }
    static void task_3()
    {
        double e; // Требуемая точность суммы ряда
        while (true)
        {
            // Запрос точности у пользователя с обработкой ошибок
            Console.Write("Введите точность e (e < 1, например, 0.001): ");
            try
            {
                e = double.Parse(Console.ReadLine());
                if (e >= 1 || e <= 0)
                {
                    // Создаём исключение
                    Console.WriteLine("Точность e должна быть меньше 1 и больше 0");
                }
                else break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода. Введите число.");
                continue;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                continue;
            }
        }
        int n = 0; // Счетчик итераций (номер слагаемого)
        double sum = 0; // Сумма ряда
        double term; // Текущее слагаемое ряда
        double factorial; // Значение факториала
        Console.WriteLine("Формала an = n!/3*(n*n)");
        Console.WriteLine("Слагаемые:");
        // Цикл вычисления суммы ряда до достижения заданной точности
        do
        {
            // Увеличиваем счетчик итераций
            n++;
            // Вычисляем факториал
            factorial = Factorial(n);
            term = factorial / (3 * Math.Pow(n, n));
            sum += term;
            // Выводим слагаемое
            Console.WriteLine($"a{n} = {term:F10}  {sum:F10}");
        } while (Math.Abs(term) >= e);
        Console.WriteLine($"\nСумма ряда: {sum:F10}");
        Console.WriteLine($"Количество слагаемых: {n}");
    }
    // Функция вычисления факториала числа n
    static double Factorial(int n)
    {
        // Базовый случай: факториал 0 равен 1
        if (n == 0) return 1;
        double result = 1;
        // Итеративное вычисление факториала
        int i = 1;
        while (i <= n) result *= i++;
        return result;
    }
}