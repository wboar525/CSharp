// Показать двумерный массив размером m×n заполненный целыми числами
// Создать массив из mxn элементов
// Заполнить случайными целыми числами от 0 до 999
// Вывести массив на экран

int[,] Create2Array(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

int[,] Fill2Array(int[,] array)
{
    int m = array.GetUpperBound(0) + 1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 1000);
        }
    }
    return array;
}

void Print2ArrayConsole(int[,] array)
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
}

/* string PrintArrayToString(int[,] array)
{
    int m = array.GetUpperBound(0)+1;
    int n = array.Length / m;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} \t");            
        }
    }
} */

int m = 3; // количество строк
int n = 6; // количество столбцов
int[,] array = Create2Array(m, n);
Fill2Array(array);
Print2ArrayConsole(array);
