// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print2ArrayConsole(int[,] array) // выводим массив на печать
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.GetUpperBound(1) + 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Fill2ArrayRandom(int[,] array) // заполняем массив случайными числами
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int FindMinRowSum(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int minsum = 0;
    int row = 0;

    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }

        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row + 1;
}

int m = 3;
int n = 5;
int[,] array = new int[m, n];
array = Fill2ArrayRandom(array);
Print2ArrayConsole(array);
System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой элементов номер " + FindMinRowSum(array));