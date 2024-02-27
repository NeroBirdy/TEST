using System;

namespace LABA3
{
    public class Variant3
    {
        public int[,] searchElements(int[] arr, int c)
        {

            int indx = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > c)
                {
                    indx = i;
                    break;
                }
            }

            if (indx == -1)
            {
                return new int[,] { { -1, -1 } };
            }
            int[,] founded = new int[arr.Length, 2];

            for (int i = indx, j = 0; i < arr.Length; i++)
            {
                if (arr[i] > c)
                {
                    founded[j, 0] = arr[i];
                    founded[j, 1] = i;
                    j++;
                }
            }

            return founded;
        }
    }


    public class Program
    {
        public static void Main()
        {
            int n, c, number;
            string[] str_arr;
            int[] arr;
            Console.WriteLine("Введите n : ");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "")
                {
                    Console.WriteLine("Вы не ввели число : ");
                    input = Console.ReadLine();
                    continue;
                }
                if (input[0] == '-')
                {
                    Console.WriteLine("Введите значение без минуса : ");
                    input = Console.ReadLine();
                    continue;
                }
                if (int.TryParse(input, out n))
                {
                    if (n > 0 && n <= 10)
                    {
                        Console.WriteLine("Введите массив через пробел : ");
                        break;
                    }
                    Console.WriteLine("Введите значение от 0 до 10 : ");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Введите целое число : ");
                    input = Console.ReadLine();
                }
            }

            input = Console.ReadLine();
            while (true)
            {
                arr = new int[n];
                bool check = true;
                bool error = false;
                str_arr = input.Split(' ');
                if (str_arr.Length != n)
                {
                    Console.WriteLine("Введите массив через пробел, состоящий из n элементов");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 0; i < str_arr.Length; i++)
                {
                    if (int.TryParse(str_arr[i], out number))
                    {
                        if (number > -1000 && number < 1000)
                        {
                            arr[i] = number;
                        }
                        else
                        {
                            Console.WriteLine("Введите массив, состоящий из элементов от -1000 до 1000 : ");
                            input = Console.ReadLine();
                            error = true;
                            check = false;
                            break;
                        }
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("Введите C");
                    break;
                }
                else
                {
                    if (!error)
                    {
                        Console.WriteLine("Введите корректно массив через пробел : ");
                        input = Console.ReadLine();
                    }
                }
            }
            input = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(input, out c))
                {
                    if (c > -1000 && c < 1000)
                    {
                        break;
                    }
                    Console.WriteLine("Введите значение от -1000 до 1000 : ");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Введите целое число : ");
                    input = Console.ReadLine();
                }
            }
            Variant3 var = new Variant3();
            int[,] result = var.searchElements(arr, c);
            if (result.GetLength(0) == 1 && result[0, 1] == -1)
            {
                Console.WriteLine("В данном массиве нет чисел, которые больше C");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i, 0] == 0 && result[i, 1] == 0)
                    {
                        break;
                    }
                    Console.WriteLine($"number = {result[i, 0]}, index = {result[i, 1]}");
                }
            }
        }
    }
}
