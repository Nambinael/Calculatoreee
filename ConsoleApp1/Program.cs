using System.Diagnostics;
using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool zxc = true;
            int status;
            string statusCheck;

            while (zxc == true)
            {

                Console.Clear();
                Console.WriteLine("Калькулятор");
                Console.WriteLine("1. Сложение 2 чисел");
                Console.WriteLine("2. Вычитание первого из второго");
                Console.WriteLine("3. Переможение 2 чисел");
                Console.WriteLine("4. Разделить первое число на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал числа");
                Console.WriteLine("9. Выйти из программы");

                Console.WriteLine("Выберите вариант:");
                option = Convert.ToInt16(Console.ReadLine());
                #region Сложение
                if (option == 1)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите первое число: ");
                        int variable1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        int variable2 = Convert.ToInt16(Console.ReadLine());
                        int result = variable1 + variable2;
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Вычиатание
                if (option == 2)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите первое число: ");
                        int variable1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        int variable2 = Convert.ToInt16(Console.ReadLine());
                        int result = variable1 - variable2;
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Умножение
                if (option == 3)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите первое число: ");
                        int variable1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        int variable2 = Convert.ToInt16(Console.ReadLine());
                        int result = variable1 * variable2;
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Деление
                if (option == 4)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите первое число: ");
                        float variable1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        float variable2 = Convert.ToInt16(Console.ReadLine());
                        float result = variable1 / variable2;
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Степень N
                if (option == 5)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите первое число: ");
                        int variable1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        int variable2 = Convert.ToInt16(Console.ReadLine());
                        int result = 1;
                        for (int i = 0; i < variable2; i++)
                        {
                                result *= variable1;
                        }
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Квадратный корень числа
                if (option == 6)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите  число: ");
                        double variable1 = Convert.ToDouble(Console.ReadLine());
                        double result = Math.Sqrt(variable1);
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Процент от числа
                if (option == 7)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите число: ");
                        double variable1 = Convert.ToInt16(Console.ReadLine());
                        double result = variable1 / 100;
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Факториал числа
                if (option == 8)
                {
                    zxc = false;
                    Console.Clear();
                    status = 1;
                    while (status == 1)
                    {

                        status = 0;
                        Console.WriteLine("Введите число: ");
                        int variable1 = Convert.ToInt16(Console.ReadLine());
                        int result = 1;
                        for (int i = 1; i <= variable1; i++)
                        {
                            result *= i;
                        }
                        Console.WriteLine("Ваш результат " + $"{result}");
                        Console.WriteLine("Продолжить? 1/2");
                        statusCheck = Console.ReadLine();

                        if (statusCheck == "1")
                        {
                            status = 1;
                        }
                        else if (statusCheck == "2")
                        {
                            status = 2;
                        }
                    }
                    if (status == 2)
                    {
                        zxc = true;
                    }
                }
                #endregion

                #region Выход из программы
                if (option == 9)
                {
                    Process.GetCurrentProcess().Kill();
                }
                #endregion
                
            }
        }
    }
}

