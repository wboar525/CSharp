// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortDescendOrderRows(int[,] array) //каждую строку массива запишем в новый одномерный массив который отсортируем встроенными методами
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);

    int[] array1 = new int[width];

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            array1[j] = array[i,j];
        }
        Array.Sort(array1);
        Array.Reverse(array1);
        for (int j = 0; j < width; j++)
        {
            array[i,j] = array1[j];
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
array = SortDescendOrderRows(array);
Print2ArrayConsole(array);