/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");    // Просим пользователя ввести размер массива, и заполнить его числами.
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write($" Введите {i} -й элемент: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        var result = string.Join(", ", arr);
        Console.WriteLine($"[{result}]");


        var posNums = arr.Where(n => n > 0);
        Console.WriteLine("Количество  чисел больше нуля: {0}", posNums.LongCount());
    }
}