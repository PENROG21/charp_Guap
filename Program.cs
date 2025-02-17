using System;
public class SeriesSum
{
    public static void Main(string[] args)
    {
        int number;
        // Цикл для работы с пользователем.
        while (true)
        {
<<<<<<< HEAD
            Console.Write("\nВведите номер задачи или 4 для выхода: ");
=======
            Console.Write("\nВведите номер задачи или 0 для выхода: ");
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD
                case 4:
                    task_4();
                    break;
                case 5:
                    task_5();
                    break;
=======
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
            }
        }
    }
    static void task_1()
    {
<<<<<<< HEAD
        /*Выведите значения функции y= f ( x) и ее аргумента в виде таблицы значений
         * из диапазона x∈[a ;b ] с шагом h. Значения a, b и h запросите у пользователя. Вид
         * функции, соответствующий номеру индивидуального 
         * варианта задания приведен в
         * таблице 1
         * Формула (2 + x * x)/Sin(x)   
        */
=======
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD
        for (double x = start; (step > 0 && x < end) || 
            (step < 0 && x > end); x += step)
=======
        for (double x = start; (step > 0 && x < end) || (step < 0 && x > end); x += step)
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD
        /*
         * 9 Вычислить:
         * (1+sin 0 .1 ) (1+sin 0 .2 )… (1+sin 10 ) .
         */
=======
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD
        /*
         * Найдите сумму ряда с точностью e (e<1, значение запросите у пользователя,
         * например, e=0,001), общий член которого an задан в соответствии с номером
         * индивидуального варианта таблицы 2 Результатом работы программы являются
         * значение суммы ряда и количество слагаемых, а также и сами слагаемые.
         * Таблица 2 – Варианты задания 3
         * a = n !n ;3 nn
         */
=======
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD

                Console.WriteLine("Ошибка: " +
                    "Неверный формат ввода. Введите число.");
=======
                Console.WriteLine("Ошибка: Неверный формат ввода. Введите число.");
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
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
<<<<<<< HEAD
    static void task_5()
    {
        /*
         * N(10,10)
         * Для целочисленной матрицы найдите для каждой
         * строки число элементов, кратных пяти, и
         * наибольший из полученных результатов
         */
        int n;
        int max_number = 0;

        // Генерация массива случайных чисел.
        Random random = new Random();
        int[,] array = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            n = 0;
            for (int j = 0; j < 10; j++)
            {
                array[i, j] = random.Next(-100, 100); //Генерируем числа от -100 до 99.  Можно изменить диапазон.
                if (array[i, j] % 5 == 0) n++;
            }
            Console.WriteLine($"В строке {i + 1} == {n}");
            if (n > max_number) max_number = n;

        }
        Console.WriteLine($"Maw = {max_number}");
        iput_array(array);
    }

    static void iput_array(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // 1 - Столбец
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int task_4()
    {
        /*
         * N(N) Определите сумму элементов массива N, кратных трем
         */
        Console.Write("Введите размер массива N: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Некорректный ввод. Введите неотрицательное целое число.");
            return 0; // Возвращаем 0 в случае ошибки ввода
        }

        Random random = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-100, 100);
            Console.WriteLine(array[i]);
        }

        int sum = 0;
        foreach (int number in array)
        {
            if (number % 3 == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"Сумма элементов массива, кратных трем: {sum}");
        return sum;
    }
=======
>>>>>>> 9160edf840ca9b469ead4c853d260629a42f2d00
}