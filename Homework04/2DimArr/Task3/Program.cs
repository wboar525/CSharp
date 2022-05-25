// В двумерном массиве n×k заменить четные элементы на противоположные
// Создать массив из nxk элементов
// Заполнить случайными целыми числами от 0 до 999
// Вывести массив на экран
// Заменить четные значения на противоположные
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
            array[i, j] = new Random().Next(0, 1000);
        }
    }
    return array;
}

int[,] ReplaceEvenWithMinus(int[,] array)
{
    int n = array.GetUpperBound(0) + 1;
    int k = array.GetUpperBound(1) + 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            if (array[i, j] % 2 == 0) array[i,j] = -array[i,j];
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
int[,] new_array = ReplaceEvenWithMinus(array);
Print2ArrayConsole(new_array);