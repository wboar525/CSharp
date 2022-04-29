// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// Создать массив из nxk элементов
// Заполнить случайными целыми числами от 0 до 99
// Вывести массив на экран
// Заменить значения в ячейках где оба индекса четные на их квадраты
// Вывести новый массив на экран

int[,] Create2Array(int n, int k)
{
    int[,] array = new int[n, k];
    return array;
}

int[,] Fill2Array(int[,] array)
{
    int n = array.GetUpperBound(0) + 1;
    int k = array.Length / n;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

int[,] ReplaceEvenIndexWithSquare(int[,] array)
{
    int n = array.GetUpperBound(0) + 1;
    int k = array.GetUpperBound(1) + 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
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
    System.Console.WriteLine();
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
int[,] new_array = ReplaceEvenIndexWithSquare(array);
Print2ArrayConsole(new_array);