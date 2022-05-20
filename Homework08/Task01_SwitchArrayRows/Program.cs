// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] SwitchArrayRows(int[,] array) // меняем первую и последнюю строки массива
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    int first = 0;
    int last = height-1;
    for (int i = 0; i < width; i++)
    {
        int tmp = array[first,i];
        array[first,i] = array[last,i];
        array[last,i] = tmp;
    }
    return array;
}

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
            array[i, j] = new Random().Next(0,100);
        }
    }
    return array;
}

int m = 5;
int n = 5;
int[,] array = new int[m,n];
array = Fill2ArrayRandom(array);
Print2ArrayConsole(array);
System.Console.WriteLine();
array = SwitchArrayRows(array);
Print2ArrayConsole(array);